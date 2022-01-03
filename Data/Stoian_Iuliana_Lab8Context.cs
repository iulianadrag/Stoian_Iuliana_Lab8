using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stoian_Iuliana_Lab8.Models;

namespace Stoian_Iuliana_Lab8.Data
{
    public class Stoian_Iuliana_Lab8Context : DbContext
    {
        public Stoian_Iuliana_Lab8Context (DbContextOptions<Stoian_Iuliana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stoian_Iuliana_Lab8.Models.Book> Book { get; set; }
    }
}
