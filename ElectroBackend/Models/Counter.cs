using System;

namespace ElectroBackend.Models
{
    public class Counter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateLastCheck { get; set; }
        public virtual CounterBrand Brand { get; set; }
        public Counter()
        {

        }
    }
}