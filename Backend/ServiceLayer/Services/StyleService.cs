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
    public class StyleService : IStyleService
    {
        private readonly IStyleRepository _styleRepository;
        private readonly IPaintingRepository _paintingRepository;
        public StyleService(
            IStyleRepository styleRepository, 
            IPaintingRepository paintingRepository)
        {
            _styleRepository = styleRepository;
            _paintingRepository = paintingRepository;
        }

        public async Task CreateStyle(StyleDto dto)
        {
            try
            {
                await _styleRepository.Create(StyleMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task DeleteStyle(int id)
        {
            try
            {
                var affectedPaintings = await _paintingRepository.GetQueryable()
                    .Where(x => x.StyleId == id)
                    .ToListAsync()
                    .ConfigureAwait(false);

                if (affectedPaintings.Count() > 0)
                {
                    foreach (var painting in affectedPaintings)
                    {
                        painting.StyleId = null;
                        await _paintingRepository.Update(painting);
                    }
                }

                await _styleRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<List<StyleDto>> GetAllStyles()
        {
            try
            {
                var records = await _styleRepository.GetAll();
                return records.Select(x => StyleMapper.ToDto(x)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task<StyleDto?> GetStyleById(int id)
        {
            try
            {
                var record = await _styleRepository.GetById(id);
                return record != null ? StyleMapper.ToDto(record) : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

        public async Task UpdateStyle(StyleDto dto)
        {
            try
            {
                await _styleRepository.Update(StyleMapper.ToEntity(dto));
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong: " + ex.Message + " - " + ex.InnerException);
            }
        }

    }

}
