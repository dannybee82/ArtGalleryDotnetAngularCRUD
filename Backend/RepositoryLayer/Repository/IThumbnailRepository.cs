using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IThumbnailRepository
    {
        Task<List<Thumbnail>> GetAll();

        IQueryable<Thumbnail> GetQueryable();

        Task<Thumbnail?> GetById(int id);

        Task<List<Thumbnail>> GetByIds(List<int> ids);

        Task Create(Thumbnail entity);

        Task Update(Thumbnail entity);

        Task Delete(int id);
    }

}
