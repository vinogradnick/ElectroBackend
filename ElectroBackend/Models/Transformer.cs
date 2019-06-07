using System;
using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Transformer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual TransformerModel Model { get; set; }
        public virtual TransformerType Type { get; set; }
        public virtual List<TransformerWorkload> TransformerWorkloads { get; set; }
        public DateTime DateInstall { get; set; }
        public DateTime DateCheck { get; set; }
        public Transformer()
        {

        }
    }
}