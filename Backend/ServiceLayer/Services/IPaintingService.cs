using RepositoryLayer.Entity;
using RepositoryLayer.PagingSorting;
using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IPaintingService
    {
        Task CreatePainting(PaintingDto dto);

        Task UpdatePainting(PaintingDto dto);

        Task DeletePainting(int id);

        Task<List<PaintingDto>> GetAllPaintings();

        Task<PaginatedList<PaintingDto>> FilterPaintings(int? pageNumber, int? pageSize, FilterDataDto filter);

        Task<PaintingDto?> GetPaintingById(int id, bool getThumbnail);

        Task<PaginatedList<PaintingDto>> GetList(int? pageNumber, int? pageSize);
    }

}