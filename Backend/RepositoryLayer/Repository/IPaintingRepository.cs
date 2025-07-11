using RepositoryLayer.Entity;
using RepositoryLayer.PagingSorting;
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

        Task<PaginatedList<Painting>> GetList(int? pageNumber, int? pageSize);

        Task<PaginatedList<Painting>> GetList(IQueryable<Painting> query, int? pageNumber, int? pageSize);

        Task<Painting?> GetById(int id);

        Task Create(Painting entity);

        Task Update(Painting entity);

        Task Delete(int id);
    }

}
