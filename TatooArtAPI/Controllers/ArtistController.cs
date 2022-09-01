using Microsoft.AspNetCore.Mvc;
using TatooArt.Core.Interfaces;
using TatooArt.Model.Models;
using TattoArtAPI;

namespace TatooArt.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;
        
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet(Name = "GetArtists")]
        public ActionResult<IEnumerable<Artist>> GetArtists()
        { 
            
            return Ok(_artistService.GetAllArtist());
        }

        [HttpGet(Name = "ArtistsByExpertize")]
        public ActionResult<IEnumerable<Artist>> ArtistsByExpertize(int expertizeId)
        {
            
            return Ok(_artistService.GetAllArtistByExpertize(expertizeId));
        }

        [HttpPost(Name = "Save")]
        public ActionResult<Guid> Save(Artist artist)
        {

            return Ok(_artistService.Save(artist));
        }
    }
}
