using System;
using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Workload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int? TpId { get; set; }
        public virtual List<BusbarSection> BusbarSections { get; set; }
        public virtual List<Phase> Phases { get; set; }
        public Workload()
        {

        }
    }
}