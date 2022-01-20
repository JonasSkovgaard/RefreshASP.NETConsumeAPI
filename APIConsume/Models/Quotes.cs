using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIConsume.Models
{
    public class Quotes
    {
        public int Id { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
        public string Series { get; set; }
    }
}