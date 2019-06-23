using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Tp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Section> Sections { get; set; }
        public virtual Transformer Transformer { get; set; }
        public int? FiderId { get; set; }
        public virtual Fider Fider { get; set; }

        public virtual  List<Workload> Workloads { get; set; }
        public Tp()
        {

        }
    }
}