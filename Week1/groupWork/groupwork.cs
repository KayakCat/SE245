using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace is the identifier/title of the program
namespace Week1_Samplel{
//class Program is the object that holds the code
    class Program
    {
    // this section of code prompts user input
        static void Main(string[] args)
        {
            //intialized variables
            String strFirst, strOperand, strNum1, strNum2;

            int32 intNum1 = 0, intNum2 = 0, intNum3 = 0, intResult = 0;
            Double dblResult = 0;

            Console.WriteLine("Hello There!");//greets user
            Console.Write("Please enter your first name: ");//prompts user to enter name
            strFirst = Console.ReadLine();//stores user input as strFirst

            Console.WriteLine("Hello " + strFirst + "! Let's do some math!"); //displays user name and prompts user to start using calculator
            Console.Write("Please enter the first number: ");//prompts user to enter first number
            strNum1 = Console.ReadLine();//stores first number as strNum1
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE, POWER): ");//prompts user to enter a math operation
            strOperand = Console.ReadLine().ToUpper();//stores users choice
            Console.Write("Please enter the second number: ");//prompts user to enter a second number

            strNum2 = Console.ReadLine();//stores second number as strNum2
            intNum1 = int32.Parse(strNum1);
            intNum2 = Convert.ToInt32(strNum2);
            
            //conditional statements to determine which operation to use and display output
            switch (strOperand)
            {
                case "PLUS":
                    dblResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    dblResult = intNum1 - intNum2;
                    break;
                case "MULTIPLY":
                    dblResult = intNum1 * intNum2;
                    break;
                case "DIVIDE":
                    dblResult = intNum1 / intNum2;
                    break;
                case "POWER":
                    dblResult = Math.pow (intNum1,intNum2);
                    
                    break;
            }
            //parses operation result
            //dblResult = (Double) intResult;
            //returns result to console
            if (strOperand == "PLUS")
                Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals:{dblResult}");
            else if (strOperand == "MINUS")
                Console.WriteLine($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MULTIPLY")
                Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "DIVIDE")
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "POWER") 
                Console.WriteLine($"\n\nThe power of {intNum1} by {intNum2} equals: {dblResult}"); 

               
                //exits program
        Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}