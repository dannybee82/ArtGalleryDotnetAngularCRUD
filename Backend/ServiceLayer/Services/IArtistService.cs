using ServiceLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IArtistService
    {
        Task CreateArtist(ArtistDto dto);

        Task UpdateArtist(ArtistDto dto);

        Task DeleteArtist(int id);

        Task<List<ArtistDto>> GetAllArtists();

        Task<ArtistDto?> GetArtistById(int id);
    }

}