using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public  class Table
    {
        public string Name { get; set; }
        public List<Boxes> Boxes { get; set; }
        public List<Labels> Labels { get; set; }
    }
}