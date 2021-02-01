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


            criminals[0].AddCrime(new Crime(new Crime(DateTime.Parse("31/01/2021")), "Ascot", "Armed Robbery"));

            //add crimes to all 3 criminals
            //Write a for loop thtat lopps through all 2 criminals
            //Loops through each crime for each criminal and prints out all the information
        }
    }
}
