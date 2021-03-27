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
            string exam, courseName, courseNum, course;
            int couseNumber;
            double grade,sum = 0, average = 0;

            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(1.00);
            courseGrades["MIS3013"].Add(0.80);

            List<double> mis3033Grades = new List<double>();
            mis3033Grades.Add(1.00);
            mis3033Grades.Add(0.79);
            mis3033Grades.Add(0.99);
            courseGrades.Add("MIS3033", mis3033Grades);

            Console.WriteLine("Please enter in a course name:");
            courseName = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter in a course number:");
            courseNum = Console.ReadLine();
            while (int.TryParse(courseNum, out couseNumber) == false)
            {
                Console.WriteLine("You did not enter in a course number. Please try again");
                courseNum = Console.ReadLine();
            }
            course = courseName + couseNumber;

            if (courseGrades.ContainsKey(course))
            {
                Console.WriteLine("This course already exits. Please try again!");
      
            }
            else
            {
                courseGrades.Add(course, new List<double>());
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please enter in your grade:");
                    exam = Console.ReadLine();
                    while (double.TryParse(exam,out grade) == false)
                    {
                        Console.WriteLine("You did not enter in an exam grade. Please try again!");
                        exam = Console.ReadLine();
                    }
                    courseGrades[course].Add(grade/100);
                }
            }


            List<double> averageList = new List<double>();
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];
                for (int i = 0; i < grades.Count; i++)
                {
                    sum += grades[i];
                    average = sum / grades.Count;
                }
                 averageList.Add(average);
                sum = 0;
            }

            List<string> courses = new List<string>();
            foreach (string value in courseGrades.Keys)
            {
                courses.Add(value);
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"Your course in {courses[i]} has an average of {averageList[i].ToString("P")}");
            }
            
        }
    }
}
