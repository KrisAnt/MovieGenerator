using MovieGenerator.DAL.Models;

namespace MovieGenerator.DAL
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RecMovie { get; set; }
        public string FavMovie { get; set; }
        public List<Movie> Movies { get; set; }
    }
}