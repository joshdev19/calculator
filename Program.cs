using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first number?");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What operator you gonna use? +, -, *, or /");
            string oper = Console.ReadLine();
            
            Console.WriteLine("What is your second number?");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool isAdd = (oper == "+");
            bool isSub = (oper == "-");
            bool isMul = (oper == "*");
            bool isDiv = (oper == "/");

            if ( isAdd )
                result = add(number1, number2);
            if ( isSub )
                result = subtract(number1, number2);
            if ( isMul )
                result = multiply(number1, number2);
            if ( isDiv )
                result = division(number1, number2);

            Console.WriteLine("The answer is " + result);

            Console.ReadLine();

        }

        static double add( double num1, double num2 )
        {
            return num1 + num2;
        }
        static double subtract( double num1, double num2 )
        {
            return num1 - num2;
        } static double multiply( double num1, double num2 )
        {
            return num1 * num2;
        } static double division( double num1, double num2 )
        {
            return num1 / num2;
        }

    }
}
