using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class program
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Hello World");
            string message = "I am Shakil";
            Console.WriteLine(message);
            int num = 10;
            Console.WriteLine("Result :"+ (num+20));
            int result = num + 20;
            Console.WriteLine("Result :" + result);
            string msgg = "I am Md Abdullah Al Shakil" + " I am in CSE";
            Console.WriteLine(msgg);

            msgg = "I am Md Abdullah Al Shakil." + "\nI am in CSE";
            Console.WriteLine(msgg);

            msgg = "I am Md Abdullah Al Shakil." +Environment.NewLine+ "I am in CSE";
            Console.WriteLine(msgg);
        }
    }
}