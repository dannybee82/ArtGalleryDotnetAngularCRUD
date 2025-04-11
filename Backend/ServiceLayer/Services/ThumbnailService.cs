using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class ThumbnailService : IThumbnailService
    {
        private readonly IPaintingRepository _paintingRepository;
        private readonly IThumbnailRepository _thumbnailRepository;

        public ThumbnailService(
            IPaintingRepository paintingRepository,
            IThumbnailRepository thumbnailRepository)
        {
            _paintingRepository = paintingRepository;
            _thumbnailRepository = thumbnailRepository;            
        }

        public async Task<List<ThumbnailDto>> GetUnusedThumbmnails()
        {
            try
            {
                var thumbnailIdsInUse = await _paintingRepository
                    .GetQueryable()
                    .Select(x => x.ThumbnailId)
                    .ToListAsync()
                    .ConfigureAwait(false);

                var query = await _thumbnailRepository.GetQueryable()
                    .Where(x => !thumbnailIdsInUse.Contains(x.Id))
                    .ToListAsync()
                    .ConfigureAwait(false);

                List<ThumbnailDto> unused = new();

                if (query.Count() > 0)
                {
                    foreach (var q in query)
                    {
                        unused.Add(ThumbnailMapper.ToDto(q, false));
                    }
                }

                return unused;
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}