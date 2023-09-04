using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    // Esta clase posee la responsabilidad de conocer los datos necesarios del paciente, así como también se encarga de verificar 
    // que los datos proporcionados sean correctos.
    public class Patient 
    {
        public string Name { get ; private set ; }
        public string PhoneNumber { get ; private set ; }
        public string Id { get ; private set ; }
        public int Age { get ; private set ; }

        
        public Patient(string patientName, string patientPhone, string id, int age)
        {
            if (VerifyName(patientName))
            {
                this.Name = patientName;
            
            }

            if (VerifyPhone(patientPhone))
            {
                this.PhoneNumber = patientPhone;
                
            }

            if (VerifyId(id))
            {
                this.Id = id;
                
            }

            if (VerifyAge(age))
            {
                this.Age = age;
                
            }

        }

        private static bool VerifyName(string name)
        {
            return (!string.IsNullOrEmpty(name));
        }

        private static bool VerifyPhone(string phoneNumber)
        {
            return (!string.IsNullOrEmpty(phoneNumber));
        }

        private static bool VerifyId(string id)
        {
            return (!string.IsNullOrEmpty(id));
        }
        
        private static bool VerifyAge(int age)
        {
            return age>0;
        }
    }
}