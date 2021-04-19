using aplikacje_WWW_zad_5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_zad_5.Data
{
    public class ContextClass : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public ContextClass(DbContextOptions options) : base(options) { }
    }
}
