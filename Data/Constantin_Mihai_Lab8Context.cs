using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_Lab8.Models;

namespace Constantin_Mihai_Lab8.Data
{
    public class Constantin_Mihai_Lab8Context : DbContext
    {
        public Constantin_Mihai_Lab8Context (DbContextOptions<Constantin_Mihai_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Constantin_Mihai_Lab8.Models.Book> Book { get; set; }

        public DbSet<Constantin_Mihai_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Constantin_Mihai_Lab8.Models.Category> Category { get; set; }
    }
}
