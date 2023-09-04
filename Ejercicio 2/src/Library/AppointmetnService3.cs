using System;
using System.Text;

namespace Library
{
    // Esta clase se encarga de la creación y presentación de información sobre las consultas médicas.
    public class AppointmentService3
    {
        public static string CreateAppointment(Patient patient, Doctor doctor_, DateTime appointmentDate, string appointmentPlace)
        {  
            StringBuilder text = new();
            text.Append("Appointment scheduling...\n");

            Appointment appointment = new(patient, doctor_, appointmentDate, appointmentPlace);
            string name = patient.Name;
            string doctor = doctor_.Name;
            text.Append($"{name} has scheduled an appointment whit Dr. {doctor}\n");
            text.Append("Information about the appointment\n");
            text.Append($"Date: {appointment.DateTime}\n");
            text.Append($"Place: {appointment.AppointmentPlace}\n");
            text.Append($"The appointment number is: {appointment.consultNumber}\n");
            return text.ToString();
        }
    }
}