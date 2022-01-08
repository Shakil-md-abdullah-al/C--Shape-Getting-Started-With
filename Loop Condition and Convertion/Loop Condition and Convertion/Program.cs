using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking Condition");
            Console.WriteLine("Enter Score");
            string englishScoreString = Console.ReadLine();
            int englishScore = Convert.ToInt32(englishScoreString);
            if (englishScore <= 50)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Enter Score of Sabbir");
            Console.Write("Bangla : ");
            string Bangla = Console.ReadLine();
            int Ban = Convert.ToInt32(Bangla);
            Console.Write("English : ");
            string English = Console.ReadLine();
            int Eng = Convert.ToInt32(English);
            Console.Write("Math : ");
            string Math = Console.ReadLine();
            int Mat= Convert.ToInt32(Math);
            Console.Write("Science : ");
            string Science = Console.ReadLine();
            int Sci = Convert.ToInt32(Science);
            Console.Write("ICT : ");
            string ICT = Console.ReadLine();
            int ict = Convert.ToInt32(ICT);

            Console.Write("Total : ");
            int total= (Ban+Eng+Mat+Sci+ict);
            Console.WriteLine(total);
            float average = total / 5;

            Console.Write("Average: ");
            Console.WriteLine(average);

            if (average <= 33)
                Console.WriteLine("Fail");
            else if (average >= 34 && average <= 60)
                Console.WriteLine("A-");
            else if (average >= 71 && average <= 79)
                Console.WriteLine("A");
            else if (average >= 80 && average <= 100)
                Console.WriteLine("A+");

            //Loops
            for(int i=0; i < 10;i++)
            {
                Console.WriteLine("Hello World");
            }



        }
    }
}