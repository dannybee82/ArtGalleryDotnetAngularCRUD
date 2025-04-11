using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class ThumbnailRepository : IThumbnailRepository
    {
        private readonly MainDbContext _dbContext;

        public ThumbnailRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Thumbnail entity)
        {
            await _dbContext.Thumbnails.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.Thumbnails.Entry(record).State = EntityState.Detached;
                _dbContext.Thumbnails.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Thumbnail>> GetAll()
        {
            return await _dbContext.Thumbnails
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Thumbnail?> GetById(int id)
        {
            return await _dbContext.Thumbnails
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task<List<Thumbnail>> GetByIds(List<int> ids)
        {
            return await _dbContext.Thumbnails
                .AsNoTracking()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public IQueryable<Thumbnail> GetQueryable()
        {
            return _dbContext.Thumbnails
                .AsNoTracking();
        }

        public async Task Update(Thumbnail entity)
        {
            var record = await GetById(entity.Id);

            if (record != null)
            {
                _dbContext.Thumbnails.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

    }

}