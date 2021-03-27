using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Variables
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            List<double> mis3033Grades = new List<double>();
            List<double> averageList = new List<double>();
            List<string> courses = new List<string>();
            string exam, courseName, courseNum, course;
            int couseNumber;
            double grade,sum, average;

            //Adding the first course with the grades for the course to the dictionary
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(1.00);
            courseGrades["MIS3013"].Add(0.80);

            //Adding the second courese with the grades for the coures to the dictionary
            mis3033Grades.Add(1.00);
            mis3033Grades.Add(0.79);
            mis3033Grades.Add(0.99);
            courseGrades.Add("MIS3033", mis3033Grades);

            //Asking the user to input to a course name, number and grades and adding it to the dictionary if the course does not exists
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

            //Calculating the average for each course and adding it to a list of averages
            foreach (string courseCode in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseCode];
                sum = 0; 
                average = 0;
                for (int i = 0; i < grades.Count; i++)
                {
                    sum += grades[i];
                    average = sum / grades.Count;
                }
                averageList.Add(average);
            }

            //Adding the coures name and number to a list because I do not know how to ues diction that well to make it work properly 
            foreach (string value in courseGrades.Keys)
            {
                courses.Add(value);
            }

            //Combining the course name and number with the average grades and outputting to the user
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"Your course in {courses[i]} has an average of {averageList[i].ToString("P")}");
            }
        }
    }
}
