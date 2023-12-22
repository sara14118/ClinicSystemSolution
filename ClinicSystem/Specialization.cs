using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    internal class Specialization
    {

        public int SpecializationID { get; set; } // Primary Key
        public string SpecializationName { get; set; }
        public string Description { get; set; }

        // Navigation property for appointments
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
