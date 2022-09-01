using Newtonsoft.Json;
using System.Diagnostics;
using TatooArt.Data.Interfaces;
using TatooArt.Model.Models;

namespace TatooArt.Data.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public readonly string dbPath;

        public ArtistRepository()
        {
            dbPath = Environment.CurrentDirectory;
            dbPath = dbPath.Replace("\\TatooArtAPI", "\\TatooArt.Data\\DB\\database.json");
        }
        public Guid Save(Artist artist)
        {
            artist.id = Guid.NewGuid();
            string json = File.ReadAllText(dbPath);
            string newArtist = JsonConvert.SerializeObject(artist, Formatting.Indented);
            File.WriteAllText(dbPath, newArtist);
            return artist.id;
        }
    }
}