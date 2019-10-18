using System;

namespace exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            // A quantidade de ticks que já se passaram desde o inicio era 0001

            DateTime d2 = new DateTime(2019, 10, 17);
            DateTime d3 = new DateTime(2019, 10, 17, 20, 45, 2);
            DateTime d4 = new DateTime(2019, 10, 17, 20, 45, 2, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow; //Horario atual, porém no Grenwich

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2000-08-15"); // Converter de string para datetime
            DateTime d9 = DateTime.Parse("2000-08-15 ")

            Console.WriteLine(d8);
     }
    }
}
