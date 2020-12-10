using System;

namespace ROT_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ROT13 Rot13 = new ROT13();
            Console.Write("-->");
            string str = Console.ReadLine();
            var result = Rot13.Transform(str);

            Console.WriteLine($"Result: {result}");
        }
    }
}

