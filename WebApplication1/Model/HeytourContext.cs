using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HeytourContext : DbContext
    {
        public HeytourContext(DbContextOptions<HeytourContext> options)
            : base(options)
        {
        }


        public DbSet<Heytour> Heytour { get; set; }
    }
}
