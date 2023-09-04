using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient person1 = new("paciente1", "5555-555-555", "54673456", 21);;
            Doctor doctor = new("Pepe", "neurólogo");

            string appointmentResult = AppointmentService3.CreateAppointment(person1, doctor, DateTime.Now, "Wall Street");
            Console.WriteLine(appointmentResult);

            Patient person2 = new("paciente2", "6666-666-666", "32342342", 32);
            string appointmentResult2 = AppointmentService3.CreateAppointment(person1, doctor, DateTime.Now, "Queen Street");
            Console.WriteLine(appointmentResult2);
        }
    }
}
