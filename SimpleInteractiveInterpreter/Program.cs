using System;

namespace SimpleInteractiveInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Interpreter().Run();
            Console.ReadKey();
        }
    }
}
