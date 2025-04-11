using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IStyleRepository
    {
        Task<List<Style>> GetAll();

        Task<Style?> GetById(int id);

        Task Create(Style entity);

        Task Update(Style entity);

        Task Delete(int id);
    }

}