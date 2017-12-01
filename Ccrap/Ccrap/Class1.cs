using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Media;


namespace Ccrap
{
    class Class1
    {

        static void Main()
        {

            if (!File.Exists(@"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Verified.txt"))
            {
                File.Create(@"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Verified.txt").Dispose();
                File.WriteAllText(@"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Verified.txt", "this file verifies that you have accepted the agreement");
                string filePath2 = @"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Agree.vbs";
                Process.Start(filePath2);
                SystemSounds.Exclamation.Play();
            }
            if (File.Exists(@"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Verified.txt"))
            {
                Conv();
            }
            Conv();
        }

        static void Conv()
        {
            Console.Clear();
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            int num;
            Int32.TryParse(input, out num);
            List<int> binar = new List<int>();
            string filePath = @"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Master.vbs";
            string filePath2 = @"C:\Users\4164544\Documents\Visual Studio 2015\Projects\Ccrap\Ccrap\Master2.vbs";


            Console.WriteLine("Press B for binary or H for Hexidecimal");
            var key = System.Console.ReadKey(true);

            if (key.Key == ConsoleKey.B)
            {
                while (num >= 1)
                {
                    binar.Add(num % 2);
                    num = num / 2;


                }
                if (num <= 1)
                {
                    binar.Reverse();
                    Console.WriteLine(string.Join("", binar));

                }

            }
            if (key.Key == ConsoleKey.H)
            {
                var hex = num.ToString("X");

                Console.WriteLine(hex);
            }

            key = Console.ReadKey(false);


            Console.WriteLine("Press enter to continue or esc to close or press x to doubt or press f to pay respects...");
            Console.WriteLine(" ");
            while (true)
            {
                key = System.Console.ReadKey(true);

                if (key.Key == ConsoleKey.X)
                {

                    Process.Start(filePath);
                    Conv();
                }
                if (key.Key == ConsoleKey.F)
                {

                    Process.Start(filePath2);
                    Conv();
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Conv();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

