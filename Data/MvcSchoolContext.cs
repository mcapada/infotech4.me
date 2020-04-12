using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using It4MEProject.Models;
using Microsoft.EntityFrameworkCore;

namespace It4MEProject.Data
{
    public class MvcSchoolContext : DbContext
    {
        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options)
            : base(options)
        {
        }

        // Web application initializes the Cloud Database upon startup and gathers all the tables. 
        public DbSet<Programs> Programs { get; set; }
    }
}
