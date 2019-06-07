﻿using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public Line()
        {

        }
    }
}