using System;

namespace Delegates
{
    public class Program
    {

        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        private static void Main(string[] args)
        {
            StringerBell bell = null;
            Joiner joiner = new Joiner("== Ola ==");

            bell += PrintUpper;
            bell += PrintLower;
            bell += joiner.JoinAndPrint;

         bell.Invoke("This is the string");   
        }
    }
}
