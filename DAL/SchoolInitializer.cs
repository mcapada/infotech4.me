using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using It4MEProject.Models;

namespace It4MEProject.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var programs = new List<Programs>
            {
                new Programs{ProgramName="Bachelor of Information Technology",ProgramDesc="You will be able to specialize in the design of wireless networks and security networking",School="Centennial College"},
                new Programs{ProgramName="Wireless Networking Program",ProgramDesc="Designed to give you high demand skills in radio frequency (RF), cellular, broadband and advanced data communications",School="George Brown College"},
                new Programs{ProgramName="Computer Networking and Technical Support",ProgramDesc="Program prepares students for system administration, network administration, security, and physical and logical network design",School="Seneca College"},
            };

            programs.ForEach(s => context.Program.Add(s));
            context.SaveChanges();

            var school = new List<School>
            {
               // new School{College="Centennial College",PostalCode="M1G3T8",Lat=43.7841, Lng=-79.2287},
               // new School{College="George Brown College",PostalCode="M5A3W8",Lat=43.6513, Lng=-79.3701},
                //new School{College="Seneca College",PostalCode="M2J5G3",Lat=43.7949, Lng=-79.3476},
            };

            school.ForEach(s => context.Schools.Add(s));
            context.SaveChanges();

        }
    }
}
