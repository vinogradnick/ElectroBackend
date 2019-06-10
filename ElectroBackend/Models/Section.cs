using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Line> Lines { get; set; }
        public virtual Counter Counter { get; set; }
        public int? TpId { get; set; }

        public Section()
        {

        }
    }
}