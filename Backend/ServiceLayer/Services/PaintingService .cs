using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using RepositoryLayer.PagingSorting;
using RepositoryLayer.Repository;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Mappers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class PaintingService : IPaintingService
    {
        private readonly IPaintingRepository _paintingRepository;
        private readonly IThumbnailRepository _thumbnailRepository;
        private readonly IImageRepository _imageRepository;

        public PaintingService(
            IPaintingRepository paintingRepository, 
            IThumbnailRepository thumbnailRepository,
            IImageRepository imageRepository)
        {
            _paintingRepository = paintingRepository;
            _thumbnailRepository = thumbnailRepository;
            _imageRepository = imageRepository;
        }

        public async Task CreatePainting(PaintingDto dto)
        {
            try
            {
                await _paintingRepository.Create(PaintingMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task DeletePainting(int id)
        {
            try
            {
                var currentPainting = await _paintingRepository.GetQueryable()
                    .Include(x => x.Image)
                    .Include(x => x.Thumbnail)
                    .SingleOrDefaultAsync(x => x.Id == id)
                    .ConfigureAwait(false);

                if (currentPainting == null)
                {
                    throw new Exception("Invalid Painting.");
                }

                await _paintingRepository.Delete(id);

                int targetThumbnailId = currentPainting.ThumbnailId ?? 0;
                int targetImageId = currentPainting.ImageId ?? 0;
                
                if (targetThumbnailId > 0)
                {
                    await _thumbnailRepository.Delete(targetThumbnailId);
                }

                if (targetImageId > 0)
                {
                    await _imageRepository.Delete(targetImageId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<PaginatedList<PaintingDto>> FilterPaintings(int? pageNumber, int? pageSize, FilterDataDto filter)
        {
            try
            {
                IQueryable<Painting> query = _paintingRepository.GetQueryable()
                    .Include(x => x.Artist)
                    .Include(x => x.Style)
                    .Include(x => x.Thumbnail)
                    .OrderByDescending(x => x.Id);

                if(filter.Styles != null)
                {
                    if(filter.Styles.Count() > 0)
                    {
                        query = query.Where(x => filter.Styles.Contains(x.Style != null ? x.Style.Id : 0));
                    }                    
                }

                if(filter.Artists != null)
                {
                    if(filter.Artists.Count() > 0)
                    {
                        query = query.Where(x => filter.Artists.Contains(x.Artist != null ? x.Artist.Id : 0));
                    }                    
                }

                if(filter.Years != null)
                {
                    if(filter.Years.Count() > 0)
                    {
                        query = query.Where(x => filter.Years.Contains(x.Year));
                    }
                }

                PaginatedList<Painting> result = await _paintingRepository.GetList(query, pageNumber, pageSize);

                return new PaginatedList<PaintingDto>
                {
                    CurrentPage = result.CurrentPage,
                    From = result.From,
                    PageSize = result.PageSize,
                    To = result.To,
                    TotalCount = result.TotalCount,
                    TotalPages = result.TotalPages,
                    Items = result.Items.Select(x => PaintingMapper.ToDto(x)).ToList()
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<List<PaintingDto>> GetAllPaintings()
        {
            try
            {
                var records = await _paintingRepository.GetAll();
                return records.Select(record => PaintingMapper.ToDto(record)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<PaginatedList<PaintingDto>> GetList(int? pageNumber, int? pageSize)
        {
            PaginatedList<Painting> result = await _paintingRepository.GetList(pageNumber, pageSize);

            return new PaginatedList<PaintingDto>
            {
                CurrentPage = result.CurrentPage,
                From = result.From,
                PageSize = result.PageSize,
                To = result.To,
                TotalCount = result.TotalCount,
                TotalPages = result.TotalPages,
                Items = result.Items.Select(x => PaintingMapper.ToDto(x)).ToList()
            };
        }

        public async Task<PaintingDto?> GetPaintingById(int id, bool getThumbnail)
        {
            try
            {
                if(!getThumbnail)
                {
                    var record = await _paintingRepository.GetById(id);
                    return record != null ? PaintingMapper.ToDto(record) : null;
                }
                else
                {
                    var record = await _paintingRepository.GetQueryable()
                        .Include(x => x.Artist)
                        .Include(x => x.Style)
                        .Include(x => x.Thumbnail)
                        .SingleOrDefaultAsync(x => x.Id == id)
                        .ConfigureAwait(false);
                    return record != null ? PaintingMapper.ToDto(record) : null;
                }                
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task UpdatePainting(PaintingDto dto)
        {
            try
            {
                await _paintingRepository.Update(PaintingMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}