using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StyleController : ControllerBase
    {
        private readonly IStyleService _styleService;

        public StyleController(IStyleService styleService)
        {
            _styleService = styleService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var items = await _styleService.GetAllStyles().ConfigureAwait(false);
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
                var item = await _styleService.GetStyleById(id).ConfigureAwait(false);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] StyleDto dto)
        {
            try
            {
                await _styleService.CreateStyle(dto);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] StyleDto dto)
        {
            try
            {
                await _styleService.UpdateStyle(dto);
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
                await _styleService.DeleteStyle(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }

}