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
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IPaintingRepository _paintingRepository;

        public ArtistService(
            IArtistRepository artistRepository, 
            IPaintingRepository paintingRepository)
        {
            _artistRepository = artistRepository;
            _paintingRepository = paintingRepository;
        }

        public async Task CreateArtist(ArtistDto dto)
        {
            try
            {
                await _artistRepository.Create(ArtistMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task DeleteArtist(int id)
        {
            try
            {
                var affectedPaintings = await _paintingRepository.GetQueryable()
                    .Where(x => x.ArtistId == id)
                    .ToListAsync()
                    .ConfigureAwait(false);

                if(affectedPaintings.Count() > 0)
                {   
                    foreach(var painting in affectedPaintings)
                    {
                        painting.ArtistId = null;
                        await _paintingRepository.Update(painting);
                    }
                }

                await _artistRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<List<ArtistDto>> GetAllArtists()
        {
            try
            {
                var records = await _artistRepository.GetAll();
                return records.Select(x => ArtistMapper.ToDto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<ArtistDto?> GetArtistById(int id)
        {
            try
            {
                var record = await _artistRepository.GetById(id);
                return record != null ? ArtistMapper.ToDto(record) : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task UpdateArtist(ArtistDto dto)
        {
            try
            {
                await _artistRepository.Update(ArtistMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}
