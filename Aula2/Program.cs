using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos!");
            if(args.GetLength(0)>0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}