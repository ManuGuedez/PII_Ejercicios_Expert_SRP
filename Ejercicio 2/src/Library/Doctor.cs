using System;

namespace Library
{
    // Esta clase posee la responsabilidad de conocer el nombre del doctor y su especialidad
    public class Doctor
    {
        public string Name { get ; set ; }
        public string Spec { get ; set ; }

        public Doctor(string doctorName, string doctorSpec)
        {
            if (VerifyName(doctorName))
            {
                this.Name = doctorName;
            }
            
            if (VerifySpec(doctorSpec))
            {
                this.Spec = doctorSpec;
            }
        }

        private static bool VerifyName(string name)
        {
            return (!string.IsNullOrEmpty(name));
        }

        private static bool VerifySpec(string spec)
        {
            return (!string.IsNullOrEmpty(spec));
        }
    }
}