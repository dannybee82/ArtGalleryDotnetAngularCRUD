using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetAll();

        Task<Artist?> GetById(int id);

        Task Create(Artist entity);

        Task Update(Artist entity);

        Task Delete(int id);
    }

}