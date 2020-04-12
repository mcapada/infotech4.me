using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using It4MEProject.Models;
using Microsoft.EntityFrameworkCore;

namespace It4MEProject.Data
{
    public class MvcProgramContext : DbContext
    {
        public MvcProgramContext (DbContextOptions<MvcProgramContext> options)
            : base(options)
        {

        }

        public DbSet<Programs> Programs { get; set; }
    }
}
