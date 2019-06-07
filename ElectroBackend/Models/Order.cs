using System;

namespace ElectroBackend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public virtual OrderType Type { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateClose { get; set; }
        public virtual ElectroObject ElectroObject { get; set; }
        public Order()
        {

        }
    }
}