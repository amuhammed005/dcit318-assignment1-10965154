using System;

namespace ConsoleApplications
{
    public class GradeCalculator
    {
        public void Run()
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            int grade = int.Parse(Console.ReadLine());

            char letterGrade;

            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            Console.WriteLine($"The letter grade is: {letterGrade}");
        }
    }
}
