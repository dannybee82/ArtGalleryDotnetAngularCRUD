using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;

        public UploadImageController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }


        [HttpPost("UploadImage")]
        public async Task<IActionResult> UploadImage([FromForm] DateTime clientDate, IFormFile file)
        {
            try
            {
                await _uploadFileService.UploadImage(file);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

    }

}