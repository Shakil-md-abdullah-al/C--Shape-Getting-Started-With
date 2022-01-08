namespace HelloWorld
{
    internal class programBase
    {
        static void Main(string[] args, void v)
        {
            Console.WriteLine("Hello World");
            string message = "I am Shakil";
            Console.WriteLine(message);
            int num = 10;
            Console.WriteLine("Result :" + (num + 20));
            int result = num + 20;
            Console.WriteLine("Result :" + result);
            string msgg = "I am Md Abdullah Al Shakil" + " I am in CSE";
            Console.WriteLine(msgg);

            msgg = "I am Md Abdullah Al Shakil." + "\nI am in CSE";
            Console.WriteLine(msgg);

            msgg = "I am Md Abdullah Al Shakil." + Environment.NewLine + "I am in CSE";
            Console.WriteLine(msgg);

            //Inpute From User
            Console.WriteLine("Enter a number");
            string msge = Console.ReadLine();
            Console.WriteLine(msge);

            Console.WriteLine("Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int opt = firstNumber + secondNumber;
            Console.WriteLine("Result: " + opt);

        }
    }
}