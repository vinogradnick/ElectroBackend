using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroBackend.Models
{
    public class ElectroApiContext : DbContext
    {
       public ElectroApiContext(DbContextOptions<ElectroApiContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Fider> Fiders { get; set; }
        public DbSet<Transformer> Transformers { get; set; }
        public DbSet<Tp> Tps { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Workload> Workloads { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
}
