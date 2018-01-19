using System.Text;

namespace Assignment_1_Program_2
{
    public class InputCalculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Sum { get; set; }
        public int Difference { get; set; }
        public int Product { get; set; }
        public int Quotient{ get; set; }
        public int Modulus { get; set; }
        public string LessThanString { get; set; }
        public string GreaterThanString { get; set; }
        public string EqualString { get; set; }


        public InputCalculator(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Sum = FirstNumber + SecondNumber;
            Difference = FirstNumber - SecondNumber;
            Product = FirstNumber * SecondNumber;
            Modulus = FirstNumber % SecondNumber;
            SetComparisonStrings();
        }

        public void SetComparisonStrings()
        {
            LessThanString = FirstNumber < SecondNumber ? "is less than" : "is not less than";
            GreaterThanString = FirstNumber > SecondNumber ? "is greater than" : "is not greater than";
            EqualString = FirstNumber == SecondNumber ? "equals" : "does not equal";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{FirstNumber} + {SecondNumber} = {Sum}");
            sb.AppendLine($"{FirstNumber} - {SecondNumber} = {Difference}");
            sb.AppendLine($"{FirstNumber} * {SecondNumber} = {Product}");
            sb.AppendLine($"{FirstNumber} / {SecondNumber} = {Quotient}");
            sb.AppendLine($"{FirstNumber} % {SecondNumber} = {Modulus}");
            sb.AppendLine();
            sb.AppendLine($"{FirstNumber} {LessThanString} {SecondNumber}");
            sb.AppendLine($"{FirstNumber} {GreaterThanString} {SecondNumber}");
            sb.AppendLine($"{FirstNumber} {EqualString} {SecondNumber}");

            return sb.ToString();
        }
    }
}
