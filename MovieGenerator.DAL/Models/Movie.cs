using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGenerator.DAL.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Country> Countries { get; set; }
        public List<Actor> Actors { get; set; }
        public byte[] Image { get; set; }
        public string Duration { get; set; }
        public int GenreId { get; set; }
        public List<User> Users { get; set; }
        public int UserId { get; set; }
    }
}
