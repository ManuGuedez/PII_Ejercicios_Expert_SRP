using System;

namespace Library
{
    // Esta clase se encarga de crear el número de consulta. En este caso la lógica es muy simple, pero está por fuera
    // de la clase Appointment porque esto podría cambiar y no tendría por qué afectar a Appointment.
    public class ConsultNumber
    {
        private static int consultNumber = 1;
        public static int GetConsultNumber()
        {
            int number = consultNumber;
            consultNumber++;
            return number;
        }
    }
}