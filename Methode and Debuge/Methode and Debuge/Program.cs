using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingMethodeDebugg
{
class Program
    {
        static void Main(string[] args)
        {
           int result= Add(10, 20);
            Console.WriteLine("Result : "+result);
        }

        static int Add(int firstNumber, int secondNumber)
        {
            int sum=firstNumber+secondNumber;
            return sum;
        }
    }
}