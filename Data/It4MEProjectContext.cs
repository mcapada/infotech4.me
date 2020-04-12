using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using It4MEProject.Models;

namespace It4MEProject.Data
{
    public class It4MEProjectContext : DbContext
    {
        public It4MEProjectContext (DbContextOptions<It4MEProjectContext> options)
            : base(options)
        {
        }

        public DbSet<It4MEProject.Models.School> School { get; set; }
    }
}
