using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using aspnet_v5.Model;

namespace aspnet_v5.Persistance
{
    public class DataContext : DbContext
    {
        public DbSet<Post> Post { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base (options)
        {

        }
    }
}
