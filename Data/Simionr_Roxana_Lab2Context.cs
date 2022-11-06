using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simionr_Roxana_Lab2.Models;

namespace Simionr_Roxana_Lab2.Data
{
    public class Simionr_Roxana_Lab2Context : DbContext
    {
        public Simionr_Roxana_Lab2Context (DbContextOptions<Simionr_Roxana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Simionr_Roxana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Simionr_Roxana_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
