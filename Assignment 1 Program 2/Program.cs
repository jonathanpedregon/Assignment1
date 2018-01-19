using System;


namespace Assignment_1_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AskForResponses();
        }

        static void AskForResponses()
        {
            int firstNumber, secondNumber;
            bool validNumber;
            do
            {
                Console.WriteLine("Please enter your first number: ");
                var response = Console.ReadLine();
                validNumber = TryToParse(response, out firstNumber);
            } while (!validNumber);
            do
            {
                Console.WriteLine("Please enter your second number: ");
                var response = Console.ReadLine();
                validNumber = TryToParse(response, out secondNumber);
            } while (!validNumber);

            var calculator = new InputCalculator(firstNumber, secondNumber);
            Console.WriteLine(calculator.ToString());
            Console.Read();
        }

        static bool TryToParse(string response, out int number)
        {
            return (int.TryParse(response, out number));
        }
    }
}
