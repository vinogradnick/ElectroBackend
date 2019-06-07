using System.Collections.Generic;

namespace ElectroBackend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAddress { get; set; }
        public string PlaceInstall { get; set; }
        public bool Status { get; set; }
        public virtual Counter Counter { get; set; }
       
        public virtual List<CustomerUsage> Usages { get; set; }
        public int CounterId { get; set; }
        public Customer()
        {

        }
        
    }
}