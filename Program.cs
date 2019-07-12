using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFilesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Ákos\Desktop\text.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Nem létezik a fájl");
                System.Environment.Exit(1);
            }

            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            string[] szavak = text.Split(new[] { " " }, StringSplitOptions.None);
            Console.WriteLine("Szavak szama: " + szavak.Length);
        }
    }
}
