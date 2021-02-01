using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {
            Criminal Joel = new Criminal("Joel", 31);
            Criminal Jesus = new Criminal("Jesus", 51);
            Criminal John = new Criminal("John", 26);

            DateTime date;
            date = DateTime.Parse("31/01/2021");
            Crime crime1 = new Crime(date, "Ascot", "Armed Robbery");
            Crime crime2 = new Crime(date, "Ascot", "Assault");
            Crime crime3 = new Crime(date, "Ascot", "Felony");
            Crime crime4 = new Crime(date, "Ascot", "Voter Fraud");

            Joel.AddCrime(crime1);
            Joel.AddCrime(crime2);
            Joel.AddCrime(crime3);
           // Joel.AddCrime(crime4);

            Console.WriteLine(Joel.AddCrime(crime1));
            Console.WriteLine(Joel.AddCrime(crime2));
            Console.WriteLine(Joel.AddCrime(crime3));
            //Console.WriteLine(Joel.AddCrime(crime4));

        }
    }
}
