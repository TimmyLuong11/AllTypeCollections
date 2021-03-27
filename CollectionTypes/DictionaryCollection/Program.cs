using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 3
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            string answer;
            int count = 0;
            double grade;

            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(0.100);
            courseGrades["MIS3013"].Add(0.80);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(100);
            mis3033Grades.Add(79);
            mis3033Grades.Add(99);
            courseGrades.Add("MIS3033", mis3033Grades);

            Console.WriteLine("Please add a course code");
            answer = Console.ReadLine();
            if (courseGrades.ContainsKey(answer))
            {
                Console.WriteLine("This course already exits. Please try again!");
            }
            else
            {
                    courseGrades.Add(answer, new List<double>());
                while (count <= 2)
                {
                    Console.WriteLine("Please enter in a grade");
                    grade = Convert.ToDouble(Console.ReadLine());
                    courseGrades[answer].Add(grade);
                    ++count;
                }
            }
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];
                for (int i = 0; i < grades.Count; i++)
                {
                    Console.WriteLine(grades[i]);
                }
            }
        }
    }
}
