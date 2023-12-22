using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    internal class Appointment
    {

        public int AppointmentID { get; set; } // Primary Key
        public int PatientID { get; set; } // Foreign Key
        public int SpecializationID { get; set; } // Foreign Key
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; }

        // Navigation properties
        public virtual Patient Patient { get; set; }
        public virtual Specialization Specialization { get; set; } = new Specialization();
    }
}
