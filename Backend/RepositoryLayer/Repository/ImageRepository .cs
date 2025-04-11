using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly MainDbContext _dbContext;

        public ImageRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Image entity)
        {
            await _dbContext.Images.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> CreateAndReturnId(Image entity)
        {
            await _dbContext.Images.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.Images.Entry(record).State = EntityState.Detached;
                _dbContext.Images.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Image>> GetAll()
        {
            return await _dbContext.Images
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Image?> GetById(int id)
        {
            return await _dbContext.Images
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task Update(Image entity)
        {
            var record = await GetById(entity.Id);

            if (record != null)
            {
                _dbContext.Images.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

    }

}
