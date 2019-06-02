using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroBackend.Models
{
    public class User
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Password { get; set; }
       public string Role { get; set; }
       public int AccessLevel { get; set; }
    }
    public class Fider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public List<Tp> Tps { get; set; }
    }
    public class Tp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public List<Section> Sections { get; set; }
        public Fider Fider { get; set; }
    }
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public List<Line> Lines { get; set; }
        public Tp Tp { get; set; }
    }
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public Section Section { get; set; }
        public List<Customer> Customers { get; set; }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAddress { get; set; }
        public string PlaceInstall { get; set; }
        public bool Status { get; set; }
        public Counter Counter { get; set; }
        public Fider Fider { get; set; }
        public Tp Tp { get; set; }
        public Line Line { get; set; }
        public List<CustomerUsage> Usages { get; set; }
        
    }
    public class CustomerUsage
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Customer Customer { get; set; }
    }
    public class Counter
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public DateTime Date { get; set; }
       public DateTime DateLastCheck { get; set; }
       public CounterBrand Brand { get; set; }
    }
    public class CounterBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
    public class Transformer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransformerModel Model { get; set; }
        public TransformerType Type { get; set; }
        public List<TransformerWorkload> TransformerWorkloads { get; set; }
        public DateTime DateInstall { get; set; }
        public DateTime DateCheck { get; set; }
    }
    public class TransformerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class TransformerType
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public OrderType Type { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateClose { get; set; }
        public ElectroObject ElectroObject { get; set; }
    }
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ElectroObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
    public class BusbarSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        
    }
    public class Workload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Tp Tp { get; set; }
        public List<BusbarSection> BusbarSections { get; set; }
        public List<Phase> Phases { get; set; }
    }
    public class Phase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Line Line { get; set; }
        public List<PhaseValue> PhaseValues { get; set; }
    }
    public class PhaseValue
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Phase Phase { get; set; }
    }
    public class TransformerWorkload
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public Transformer Transformer { get; set; }
    }
}
