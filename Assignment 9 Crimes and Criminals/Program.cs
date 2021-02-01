using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {
            Criminal[] criminals = new Criminal[3];

            criminals[0] = new Criminal("Joel", 31);
            criminals[1] = new Criminal("Jesus", 51);
            criminals[2] = new Criminal("John", 26);



            criminals[0].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Ascot", "Murder"));
            criminals[0].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Mall", "Homocide"));
            criminals[0].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Hospital", "Robbery"));


            criminals[1].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "7-11", "Fraud"));
            criminals[1].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Gym", "Assault"));
            criminals[1].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "University", "Abuse of Drugs"));


            criminals[2].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Ikea", "Child Abuse"));
            criminals[2].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Mcdonalds", "Clown Abuse"));
            criminals[2].AddCrime(new Crime(DateTime.Parse("31/1/2021"), "Military Base", "Soldier Abuse"));



            for (int i = 0; i < criminals.Length; i++)
            {
                for(int x = 0; x < criminals[i].CountCrimes(); x++)
                {
                    Console.WriteLine(criminals[i].Getname() + ", " + criminals[i].GetCrime(x));
                }

                Console.WriteLine("");
            }


            //add crimes to all 3 criminals
            //Write a for loop thtat lopps through all 3 criminals
            //Loops through each crime for each criminal and prints out all the information
        }

    
    }
}
