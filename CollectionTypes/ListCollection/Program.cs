using System;
using System.Collections.Generic;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gradeList = new List<double>();
            string answer;
            double grade, sum = 0;

            Console.WriteLine("Please enter in your grade:");
            answer = Console.ReadLine();
            do
            {
                while (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine("You did not enter in an grade. Please try again!");
                    answer = Console.ReadLine();
                }
                Console.WriteLine("Please enter in your next grade. Type 'no' to quit.");
                answer = Console.ReadLine();
                gradeList.Add(grade);
            } while (answer != "no");

            for (int i = 0; i < gradeList.Count; i++)
            {
                sum += gradeList[i];
            }

            Console.WriteLine($"The average grade was a {((sum / gradeList.Count) / 100).ToString("P")}.");
        }
    }
}
