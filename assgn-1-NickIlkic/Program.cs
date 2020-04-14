using System;

namespace assgn_1_NickIlkic
{
    class Program
    {
        static void Main(string[] args)
        {
            //anonymous type
            var Shape = new
            {
                color = "Blue",
                size = "Big",
                model = "Rectangle"
            };

            //4- Explain difference between call by value and call by reference by an example
            //Call by value will use the value provided but not change the value outside the current scope
            //Call by reference will change whatever is referenced, wherever it is referenced

            //5- Write a method to take 3 arguments and print them by using interpolation
            static string Interpolation(string string1, string string2, string string3)
            {
                return $"{string1}{string2}{string3}";
            }

            Console.WriteLine(Interpolation("Colour ", "is ", "red"));

            //6- Write a method to calculate how many hours we have until next year.
            static TimeSpan TimeUntilNewYear()
            {
                DateTime now = DateTime.Now;
                DateTime newYear = new DateTime(2021, 1, 1);
                return (newYear - now)*24;
            }

            Console.WriteLine(TimeUntilNewYear());
            //7- using multi line to write your first name, last name and email
            Console.WriteLine(@"
            Nick
            Ilkic
            1295607@johnabbottcollege.net");

            //8- write your name and email in one String
            Console.WriteLine("NickIlkic1295607@johnabbottcollege.net");

            //9- what is the difference between var and dynamic

            //10- send shape anonymous type that you created in 3 into a method to print them by using interpolation
            Console.WriteLine(Interpolation(Shape.color, Shape.model, Shape.size));
        }
    }
}
