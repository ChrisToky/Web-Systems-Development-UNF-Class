//  This is traditionally the first program written.
using System;
using static System.Console;

namespace HelloWorldProgram
{
    class HelloWorld
    {
        static void Main()
        {
            WriteLine("Hello World!");
            WriteLine();

            ReadKey();
            WriteLine("this is a statement");

            WriteLine();

            WriteLine("Addition: " + 5 + 6);
        }
    }
}