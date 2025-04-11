using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly MainDbContext _dbContext;

        public ArtistRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Artist entity)
        {
            await _dbContext.Artists.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.Artists.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Artist>> GetAll()
        {
            return await _dbContext.Artists
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Artist?> GetById(int id)
        {
            return await _dbContext.Artists
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task Update(Artist entity)
        {
            var record = await GetById(entity.Id);

            if (record != null)
            {
                _dbContext.Artists.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

    }

}