using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Criminal
    {
        private string name;
        private int age;
        private Crime[] CrimesCommitted;

        public Criminal(string name, int age)
        {
            this.name = name;
            this.age = age;

            CrimesCommitted = new Crime[3];
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
            for(int i = 0; i < CrimesCommitted.Length; i++)
            {
                if (CrimesCommitted[i] == null)
                {
                    return i;
                }
            }
            return CrimesCommitted.Length;
        }

        // Mutators

        public bool AddCrime(Crime CrimeToAdd)
        {
            int CrimesCount = CountCrimes();
            if (CrimesCount < CrimesCommitted.Length)
            {
                CrimesCommitted[CountCrimes()] = CrimeToAdd;
                return true;
            }
            return false;
        }

        public string GetCrime(int crimenumber)
        {
            return CrimesCommitted[crimenumber].ToString();
        }
   

        
        

        
    }
}
