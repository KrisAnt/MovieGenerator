using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGenerator.DAL.Models
{
    public class Director
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
