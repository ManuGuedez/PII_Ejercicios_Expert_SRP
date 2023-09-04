using System;
namespace Library
{
    // Esta clase posee la responsabilidad de conocer los datos de la consulta.
    public class Appointment
    {

        public Patient Patient { get ; private set ; }
        public Doctor Doctor { get ;  private set ; }
        public DateTime DateTime { get ; private set ; }
        public string AppointmentPlace { get ; private set; }
        public double consultNumber { get ; private set ; }

        public Appointment(Patient patient, Doctor doctor, DateTime appointmentDate, string appointmentPlace)
        {
            this.Patient = patient;
            this.Doctor = doctor;
            this.DateTime = appointmentDate;
            this.AppointmentPlace = appointmentPlace;
            this.consultNumber = ConsultNumber.GetConsultNumber();
        }
        
    }
}