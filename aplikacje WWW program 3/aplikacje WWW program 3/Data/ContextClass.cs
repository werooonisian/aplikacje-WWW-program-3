using aplikacje_WWW_program_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_program_3.Data
{
    public class ContextClass : DbContext
    {
        public ContextClass(DbContextOptions optionts) : base(optionts) { }
        public DbSet<FizzBuzz> FizzBuzz { get; set; }
    }
}
