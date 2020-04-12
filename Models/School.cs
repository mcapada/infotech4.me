using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace It4MEProject.Models
{
    public class School
    {
        // Creating a Model scheme for the Database Migration to refer to
        public int Id { get; set; }
        public string College { get; set; }
        public string PostalCode { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string ProgramName { get; set; }
        public string Campus { get; set; }
        public string Link { get; set; }
    }
}
