using System.Text.Json;
using TatooArt.Core.Interfaces;
using TatooArt.Data.Interfaces;
using TatooArt.Model.Models;

namespace TatooArt.Core.Services
{
    public class ArtistService : IArtistService
    {
        public readonly IArtistRepository _artistRepository;
        
        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public IEnumerable<Artist> GetAllArtist()
        {
            IList<Artist> artists = new List<Artist>();
            return artists;
        }

        public IEnumerable<Artist> GetAllArtistByExpertize(int expertizeId)
        {
            IList<Artist> artists = new List<Artist>();
            return artists;
        }

        public Guid Save(Artist artist)
         => _artistRepository.Save(artist);
        
    }
}