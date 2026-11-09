using System;

namespace Observers
{
    public class KeyReader: AbstractStringSubject
    {
        public void ReadKeys()
        {
            ConsoleKey key;

            do
            {
               key = Console.ReadKey(true).Key;

               Item = key.ToString(); 
            }while(key != ConsoleKey.Escape);
        }
    }
}