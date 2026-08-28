using FileSignatures;
using Microsoft.AspNetCore.Http;
using RepositoryLayer.Repository;
using ServiceLayer.Settings;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class UploadFileService : IUploadFileService
    {
        private readonly IFileFormatInspector _fileFormatInspector;
        private readonly IAllowedFileFormatList _allowedFileFormatList;
        private readonly IImageRepository _imageRepository;
        private readonly IThumbnailRepository _thumbnailRepository;

        public UploadFileService(
            IFileFormatInspector fileFormatInspector, 
            IAllowedFileFormatList allowedFileFormatList,
            IImageRepository imageRepository,
            IThumbnailRepository thumbnailRepository)
        {
            _fileFormatInspector = fileFormatInspector;
            _allowedFileFormatList = allowedFileFormatList;
            _imageRepository = imageRepository;
            _thumbnailRepository = thumbnailRepository;
        }

        public async Task UploadImage(IFormFile file)
        {
            try
            {
                var fileStream = file.OpenReadStream();
                var fileFormat = _fileFormatInspector.DetermineFileFormat(fileStream);
                var fileExtension = Path.GetExtension(file.FileName).Replace(".", "").ToLower();

                var record = _allowedFileFormatList.AllowedFileList
                    .SingleOrDefault(x => x.Extension.Equals(fileExtension) && x.FileFormat
                    .Any(y => y.Equals(fileFormat)));

                if (record == null)
                {
                    throw new Exception("Not allowed file format.");
                }

                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                string base64 = Convert.ToBase64String(bytes);

                if(!base64.StartsWith("data:"))
                {
                    base64 = "data:image/" + fileExtension + ";base64," + base64;
                }
                                
                int imageParendId = await _imageRepository.CreateAndReturnId(new RepositoryLayer.Entity.Image() {
                    Base64 = base64 
                });

                //Resize image to thumbnail.
                int positionBase64 = base64.IndexOf(";base64,") + 8;
                string base64part = base64.Substring(positionBase64);
                var imageBytes = Convert.FromBase64String(base64part);

                string thumbnail = string.Empty;

                using (var image = SixLabors.ImageSharp.Image.Load(imageBytes))
                {
                    if (image.Width > 250)
                    {
                        image.Mutate(x => x.Resize(new Size(250, 0)));
                        thumbnail = image.ToBase64String(PngFormat.Instance);
                    }
                    else
                    {
                        thumbnail = base64;
                    }
                }

                if (!thumbnail.StartsWith("data:"))
                {
                    thumbnail = "data:image/png;base64," + base64;
                }

                await _thumbnailRepository.Create(new RepositoryLayer.Entity.Thumbnail()
                {
                    Base64 = thumbnail,
                    ParentImageId = imageParendId
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}