using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroBackend.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public class User
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Password { get; set; }
       public string Role { get; set; }
       public int AccessLevel { get; set; }
       public User()
        {

        }
    }
    public class Fider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Tp> Tps { get; set; }
        public Fider()
        {

        }
    }
    public class Tp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Section> Sections { get; set; }
        public virtual Fider Fider { get; set; }
        public Tp()
        {

        }
    }
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual List<Line> Lines { get; set; }
        public virtual Tp Tp { get; set; }
        public Section()
        {

        }
    }
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Voltage { get; set; }
        public string Geocode { get; set; }
        public virtual Section Section { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public Line()
        {

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAddress { get; set; }
        public string PlaceInstall { get; set; }
        public bool Status { get; set; }
        public virtual Counter Counter { get; set; }
        public virtual Fider Fider { get; set; }
        public virtual Tp Tp { get; set; }
        public virtual Line Line { get; set; }
        public virtual List<CustomerUsage> Usages { get; set; }
        public int CounterId { get; set; }
        public Customer()
        {

        }
        
    }
    public class CustomerUsage
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public virtual Customer Customer { get; set; }
        public CustomerUsage()
        {

        }
    }
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
    public class CounterBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CounterBrand()
        {

        }
        
    }
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
    public class TransformerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransformerModel()
        {

        }
    }
    public class TransformerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransformerType()
        {

        }

    }
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
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderType()
        {

        }
    }
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatus()
        {

        }
    }
    public class ElectroObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ElectroObject()
        {

        }
    }
    public class BusbarSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public BusbarSection()
        {

        }
        
    }
    public class Workload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual Tp Tp { get; set; }
        public virtual List<BusbarSection> BusbarSections { get; set; }
        public virtual List<Phase> Phases { get; set; }
        public Workload()
        {

        }
    }
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
    public class PhaseValue
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public virtual Phase Phase { get; set; }
        public PhaseValue()
        {

        }
    }
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
