using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramProject
{
    internal class Program
    {
        static void Main()
        {
            string inputSentense = Console.ReadLine();          
            
            AnagramClass sentense = new AnagramClass(inputSentense);
            Console.WriteLine(sentense.Reverse());   

            Console.ReadLine();            
        }
    }
}
