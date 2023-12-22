namespace ClinicSystem
{
    internal class Program

    {





        static string GetSpecialization()
        {
            Console.WriteLine("Select a specialization:");
            Console.WriteLine("1. Cardiology");
            Console.WriteLine("2. Dermatology");
            Console.WriteLine("3. Orthopedics");

            Console.Write("Enter the number corresponding to your specialization choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Invalid choice. Please enter a number between 1 and 3: ");
            }

            switch (choice)
            {
                case 1:
                    return "Cardiology";
                case 2:
                    return "Dermatology";
                case 3:
                    return "Orthopedics";
                default:
                    return "Unknown Specialization";
            }
        }
        static void Main(string[] args)
        {





            Console.WriteLine("Welcome to the Clinic Appointment Booking System");
            Console.WriteLine("----------------------------------------");

            // Get user details
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your contact details: ");
            string email = Console.ReadLine();

            // Get specialization details
            Console.Write("Enter specialization name: ");
            string specializationName = GetSpecialization();

            Console.Write("Enter specialization description: ");
            string specializationDescription = Console.ReadLine();

            // Get appointment details
            Console.Write("Enter appointment date (MM/dd/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime appointmentDate))
            {
                Console.Write("Enter appointment start time (HH:mm): ");
                if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan appointmentStartTime))
                {
                    // Create a new patient
                    var newPatient = new Patient
                    {
                        Name = name,
                        Email = email
                    };

                    // Create a new specialization
                    var newSpecialization = new Specialization
                    {
                        SpecializationName = specializationName,
                        Description = specializationDescription
                    };

                    // Create a new appointment
                    var newAppointment = new Appointment
                    {
                        // Date = appointmentDate.Date,
                        Date = appointmentDate,
                        Time = appointmentStartTime,
                        Status = "Scheduled",
                        Patient = newPatient,
                        Specialization = newSpecialization
                    };

                    // Save to database
                    using (var context = new ClinicDbContext())
                    {
                        // Add entities to the context and save changes
                        context.Patients.Add(newPatient);
                        context.Specializations.Add(newSpecialization);
                        context.Appointments.Add(newAppointment);

                        context.SaveChanges();
                    }

                    Console.WriteLine("\nAppointment booked successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid time format. Please enter a valid time (HH:mm).");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (MM/dd/yyyy).");
            }

            Console.ReadLine(); // Keep the console window open
        }





















    }
    }

    
