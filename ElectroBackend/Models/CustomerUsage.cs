namespace ElectroBackend.Models
{
    public class CustomerUsage
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public virtual Customer Customer { get; set; }
        public CustomerUsage()
        {

        }
    }
}