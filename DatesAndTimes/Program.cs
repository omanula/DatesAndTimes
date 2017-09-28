using System;

namespace DatesAndTimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Now = static property that will return the current values
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            // Modify dates with DATE MATH
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // multiple methods can be chained together. The data type returned
            // by the helper methods to be used in the chain. Statement more readable
            // Console.WriteLine(myValue.AddHours(3).ToShortTimeString());

            // Subtract
            // Console.WriteLine(myValue.AddDays(-2).ToShortDateString());


            // Receive certain parts of the date or time
            // Console.WriteLine(myValue.Month.ToString());
            // You can pull up many other parts of the date or time as well

            // Pass a series of integers
            // DateTime myBirthday = new DateTime(1999, 10, 05);
            // Console.WriteLine(myBirthday.ToShortDateString());


            DateTime myBirthday = DateTime.Parse("10/05/1999");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            // tells diffence between two periods of time
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();

            // Look around for abstractions, simplify the code
        }
    }
}
