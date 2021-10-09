using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS531_DonutsProject.Models
{
    public partial class DonutContext : DbContext
    {
        public DonutContext()
        {
        }
        public DonutContext(DbContextOptions<DonutContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Donuts> Donuts { get; set; }
    }
}
