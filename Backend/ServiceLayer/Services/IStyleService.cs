using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IStyleService
    {
        Task CreateStyle(StyleDto dto);

        Task UpdateStyle(StyleDto dto);

        Task DeleteStyle(int id);

        Task<List<StyleDto>> GetAllStyles();

        Task<StyleDto?> GetStyleById(int id);
    }


}
