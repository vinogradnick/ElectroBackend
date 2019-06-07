using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Fider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Tp> Tps { get; set; }
        public Fider()
        {

        }
    }
}
