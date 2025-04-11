using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ArtGalleryWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThumbnailController : ControllerBase
    {
        private readonly IThumbnailService _thumbnailService;

        public ThumbnailController(IThumbnailService thumbnailService)
        {
            _thumbnailService = thumbnailService;
        }

        [HttpGet("GetUnusedThumbnails")]
        public async Task<IActionResult> GetUnusedThumbnails()
        {
            try
            {
                var items = await _thumbnailService.GetUnusedThumbmnails().ConfigureAwait(false);
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}