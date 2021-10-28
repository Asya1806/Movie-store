using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanema.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string img { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }        
        public string Annotation { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
