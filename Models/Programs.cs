using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace It4MEProject.Models
{
    public class Programs
    {   
        [Key]
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDesc { get; set; }
        public string School { get; set; }
    }
}
