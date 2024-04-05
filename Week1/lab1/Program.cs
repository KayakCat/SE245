
using System;

namespace lab1
{
  class Program
  {
    static void Main(string[] args)
    {

      //assign variables
      string finalGrade;

      Console.WriteLine("Hello There!");//greets user
      Console.Write("Please enter Student's Name: ");//prompts user to enter name
      string studentName = Console.ReadLine();//stores user input as strName

      // Prompt user to enter grades
      Console.Write("Enter Group Project Grade: ");
      double grade1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Individual Lab Grade : ");
      double grade2 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Final Exam Grade: ");
      double grade3 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter Final Project Grade: ");
      double grade4 = Convert.ToDouble(Console.ReadLine());

      //Calculate grade average with weights by multiplying the grade with the corresponding percentage before dividing
      double gradeAvg = (grade1  + grade2 + grade3 + grade4) / 4.0 ;

      if (gradeAvg >= 90)
      {
        finalGrade = "A";
      }

      else if (gradeAvg >= 80)
      {
        finalGrade = "B";
      }

      else if (gradeAvg >= 70)
      {
        finalGrade = "C";
      }

      else if (gradeAvg >= 60)
      {
        finalGrade = "D";
      }

      else
      {
        finalGrade = "F";
      }

      //Display Student Name, Grade Average, and Final Letter Grade

      Console.WriteLine($"Student Name:{studentName}");
      
      Console.WriteLine($"Grade Average:{gradeAvg:F2}");

      Console.WriteLine($"Final Letter Grade:{finalGrade}");

    }

  } 

}

