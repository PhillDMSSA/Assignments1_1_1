namespace Assignments1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. 
               Create a simple console application and store your name, age
               (should take decimal), address in a string variable and print them back on
               console. Prompt the user to each time enter name, age and address.
           */


            //name input
            Console.WriteLine("1.");
            Console.WriteLine("Please enter your name: ");
            string nameInput = Console.ReadLine();

            //age input
            Console.WriteLine("Please enter your age: ");
            double ageInput = Convert.ToDouble(Console.ReadLine());

            //address input
            Console.WriteLine("Please enter your address: ");
            string addressInput = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Your name is {nameInput}. You are {ageInput} years old. You live at {addressInput}.");

            /* 2.
               Create a simple console application and declare basic datatypes like int, float, 
               decimal, double and print their min and max values.
            */

            //int 
            Console.WriteLine();
            Console.WriteLine("2.");
            Console.WriteLine("Please enter a whole number (int): ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            //float
            Console.WriteLine("Please enter a 'float' number (ex: 3.14f):");
            float floatInput = Convert.ToSingle(Console.ReadLine());

            //decimal
            Console.WriteLine("Please enter a dollar amount using (decimal variable): ");
            decimal decimalInput = Convert.ToDecimal(Console.ReadLine());

            //double
            Console.WriteLine("Please enter a number using (double variable) : ");
            double doubleInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Min value of 'int' & 'float' = " + Math.Min(numInput, floatInput));
            Console.WriteLine("Max value of 'decimal' & 'double' = " + Math.Max(numInput, floatInput));

            /*3.
                Write a C# Sharp program to print the sum of two numbers.
             */
            Console.WriteLine();
            Console.WriteLine("3.");
            Console.WriteLine("Enter a number: ");
            int numberInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int numberInput2 = Convert.ToInt32(Console.ReadLine());

            int sum = numberInput1 + numberInput2;

            Console.WriteLine($"The sum of the 2 numbers entered is: {sum}. ({numberInput1} " +
                $"+ {numberInput2} = {sum}) ");

            /*4. Write a C# Sharp program to print the result of dividing two numbers.
             */
            Console.WriteLine();
            Console.WriteLine("4.");
            Console.WriteLine("Enter a number: ");
            double numberInput12 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double numberInput13 = Convert.ToInt32(Console.ReadLine());

            double sum2 = numberInput1 / numberInput2;

            Console.WriteLine($"The sum of the 2 numbers entered is: {sum2}. ({numberInput12} " +
                $"/ {numberInput13} = {sum2}) ");

        }
    }
}
