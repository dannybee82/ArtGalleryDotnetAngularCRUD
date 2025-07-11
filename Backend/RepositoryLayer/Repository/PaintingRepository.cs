using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using RepositoryLayer.PagingSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class PaintingRepository : IPaintingRepository
    {
        private readonly MainDbContext _dbContext;
        private const int PageSize = 25;

        public PaintingRepository(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Painting entity)
        {
            await _dbContext.Paintings.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if (record != null)
            {
                _dbContext.Paintings.Entry(record).State = EntityState.Deleted;                
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Painting>> GetAll()
        {
            return await _dbContext.Paintings
               .AsNoTracking()
               .OrderByDescending(x => x.Id)
               .Include(x => x.Artist)
               .Include(x => x.Style)
               .Include(x => x.Thumbnail)
               .ToListAsync()
               .ConfigureAwait(false);
        }

        public async Task<Painting?> GetById(int id)
        {
            return await _dbContext.Paintings
                .AsNoTracking()
                .Include(x => x.Artist)
                .Include(x => x.Style)
                .Include(x => x.Image)
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task<PaginatedList<Painting>> GetList(int? pageNumber, int? pageSize)
        {
            IQueryable<Painting> query = _dbContext.Paintings
                .AsNoTracking()
               .OrderByDescending(x => x.Id)
               .Include(x => x.Artist)
               .Include(x => x.Style)
               .Include(x => x.Thumbnail);

            return await PaginatedList<Painting>.CreateAsync(query, pageNumber ?? 1, pageSize ?? PageSize);
        }

        public IQueryable<Painting> GetQueryable()
        {
            return _dbContext.Paintings
                .AsNoTracking();
        }

        public async Task Update(Painting entity)
        {
            var record = await GetById(entity.Id);

            if (record != null)
            {
                _dbContext.Paintings.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<PaginatedList<Painting>> GetList(IQueryable<Painting> query, int? pageNumber, int? pageSize)
        {
            return await PaginatedList<Painting>.CreateAsync(query, pageNumber ?? 1, pageSize ?? PageSize);
        }
    }

}