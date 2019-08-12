using System;
using TestLib;

namespace AutomatedTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var functions = new Functions();
            var answer = functions.Add1(3); // should return 4
            Console.WriteLine(answer);
            
        }
    }
}
