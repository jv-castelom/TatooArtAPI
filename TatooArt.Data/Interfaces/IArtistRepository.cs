using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooArt.Model.Models;

namespace TatooArt.Data.Interfaces
{
    public interface IArtistRepository
    {
        public Guid Save(Artist artist);
    }
}
