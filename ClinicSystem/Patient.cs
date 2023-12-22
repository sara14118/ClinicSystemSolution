using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    internal class Patient
    {

        public int PatientID { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation property for appointments
        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
