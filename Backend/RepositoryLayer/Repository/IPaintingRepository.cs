using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IPaintingRepository
    {
        IQueryable<Painting> GetQueryable();

        Task<List<Painting>> GetAll();

        Task<Painting?> GetById(int id);

        Task Create(Painting entity);

        Task Update(Painting entity);

        Task Delete(int id);
    }

}
