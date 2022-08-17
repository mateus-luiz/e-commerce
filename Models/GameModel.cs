using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Developer { get; set; }
        public string? ArtUrl { get; set; }
        public string? Description { get; set; }
    }
}