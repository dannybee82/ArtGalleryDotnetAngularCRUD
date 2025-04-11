using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IImageRepository
    {
        Task<List<Image>> GetAll();

        Task<Image?> GetById(int id);

        Task Create(Image entity);
        Task<int> CreateAndReturnId(Image entity);

        Task Update(Image entity);

        Task Delete(int id);
    }

}
