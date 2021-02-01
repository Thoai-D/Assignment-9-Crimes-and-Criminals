using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Criminal
    {
        private string name;
        private int age;
        private Crime[] CrimesCommited;

        public Criminal(string name, int age)
        {
            this.name = name;
            this.age = age;

            CrimesCommited = new Crime[3];
        }

        //Accessors

        public string Getname()
        {
            return name;
        }

        public int Getage()
        {
            return age;
        }

        public int CountCrimes()
        {
            for(int i = 0; i < CrimesCommited.Length; i++)
            {
                if (CrimesCommited[i] == null)
                {
                    return i;
                }
            }
            return CrimesCommited.Length;
        }

        // Mutators

        public bool AddCrime(Crime CrimeToAdd)
        {
            int CrimesCount = CountCrimes();
            if (CrimesCount < CrimesCommited.Length)
            {
                CrimesCommited[CountCrimes()] = CrimeToAdd;
                return true;
            }
            return false;
        }

        

        
    }
}
