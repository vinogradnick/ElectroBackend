using System;

namespace ElectroBackend.Models
{
    public class TransformerWorkload
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public virtual Transformer Transformer { get; set; }
        public TransformerWorkload()
        {

        }
    }
}