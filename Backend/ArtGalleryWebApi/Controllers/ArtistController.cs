using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var items = await _artistService.GetAllArtists().ConfigureAwait(false);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var item = await _artistService.GetArtistById(id).ConfigureAwait(false);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ArtistDto dto)
        {
            try
            {
                await _artistService.CreateArtist(dto);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] ArtistDto dto)
        {
            try
            {
                await _artistService.UpdateArtist(dto);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _artistService.DeleteArtist(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }

}