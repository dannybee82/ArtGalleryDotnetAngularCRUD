using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServiceLayer.DataTransferObjects;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaintingController : ControllerBase
    {
        private readonly IPaintingService _paintingService;

        public PaintingController(IPaintingService paintingService)
        {
            _paintingService = paintingService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var items = await _paintingService.GetAllPaintings();
                return Ok(items);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList(int? pageNumber, int? pageSize)
        {
            try
            {
                var list = await _paintingService.GetList(pageNumber, pageSize);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var item = await _paintingService.GetPaintingById(id, false);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetDetailsWithThumbnail")]
        public async Task<IActionResult> GetDetailsWithThumbnail(int id)
        {
            try
            {
                var item = await _paintingService.GetPaintingById(id, true);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Filter")]
        public async Task<IActionResult> Filter(int? pageNumber, int? pageSize, [FromQuery] FilterDataDto filter)
        {
            try
            {
                var items = await _paintingService.FilterPaintings(pageNumber, pageSize, filter);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] PaintingDto dto)
        {
            try
            {
                await _paintingService.CreatePainting(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] PaintingDto dto)
        {
            try
            {
                await _paintingService.UpdatePainting(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _paintingService.DeletePainting(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}
