using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooArt.Model.Models;

namespace TatooArt.Core.Interfaces
{
    public interface IArtistService
    {
        public IEnumerable<Artist> GetAllArtist();
        public IEnumerable<Artist> GetAllArtistByExpertize(int expertizeId);
        public Guid Save(Artist artist);
    }
}
