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
            string vPath = AppDomain.CurrentDomain.BaseDirectory + "Verified.meme";
            string aPath = AppDomain.CurrentDomain.BaseDirectory + "Agree.vbs";


            if (!File.Exists(vPath))
            {
                File.Create(vPath).Dispose();
                Process.Start(aPath);
                SystemSounds.Exclamation.Play();
            }
            if (File.Exists(vPath))
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
;


            Console.WriteLine("Press B for binary or H for Hexidecimal");
            var key = System.Console.ReadKey(true);
            char result = key.Key.ToString()[0];
            switch (result)
            {
                case 'B':
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

            
                break;
               case 'H':
                var hex = num.ToString("X");

            Console.WriteLine(hex);
        
                break;
               default:
                break;
        }



            string mPath = AppDomain.CurrentDomain.BaseDirectory + "Master.vbs";
            string m2Path = AppDomain.CurrentDomain.BaseDirectory + "Master2.vbs";


            Console.WriteLine("Press enter to continue or esc to close or press x to doubt or press f to pay respects...");
            Console.WriteLine(" ");
            while (true)
            {
                key = System.Console.ReadKey(true);

                if (key.Key == ConsoleKey.X)
                {

                    Process.Start(mPath);
                    Conv();
                }
                if (key.Key == ConsoleKey.F)
                {

                    Process.Start(m2Path);
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

