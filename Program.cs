using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomNumber();
        }
        static void RandomNumber()
        {
            Random random = new Random();
            int randNum = random.Next();
            Console.WriteLine("Случайное число: " + randNum);
        }
    }
}
