using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class StyleRepository : IStyleRepository
    {
        private readonly MainDbContext _dbContext;

        public StyleRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Style entity)
        {
            await _dbContext.Styles.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.Styles.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Style>> GetAll()
        {
            return await _dbContext.Styles
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Style?> GetById(int id)
        {
            return await _dbContext.Styles
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task Update(Style entity)
        {
            var record = await GetById(entity.Id);

            if (record != null)
            {
                _dbContext.Styles.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

    }

}