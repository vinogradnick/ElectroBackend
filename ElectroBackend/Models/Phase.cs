using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Phase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Line Line { get; set; }
        public virtual List<PhaseValue> PhaseValues { get; set; }
        public Phase()
        {

        }
    }
}