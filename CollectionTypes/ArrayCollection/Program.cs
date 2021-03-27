using System;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Variables
            string[] courseName = new string[3];
            int[] courseNumber = new int[3];
            string answer;
            int number;

            //Output to the user to enter in the couse subject and adding the input to an array
            Console.WriteLine("Please enter in a course subject:");
            answer = Console.ReadLine();
            courseName[0] = answer;
            for (int i = 1; i < courseName.Length; i++)
            {
                courseName[i] = answer;
                Console.WriteLine("Please enter in the next course subject:");
                answer = Console.ReadLine();
            }

            //Output to the user to enter in the couse number and adding the input to an array
            Console.WriteLine("\nPlease enter in a course number:");
            answer = Console.ReadLine();
            while (int.TryParse(answer, out number)==false)
            {
                Console.WriteLine("You did not enter in a course number. Please try agian");
                answer = Console.ReadLine();
            }
            courseNumber[0] = number;
            for (int i = 1; i < courseNumber.Length; i++)
            {
                Console.WriteLine("Please enter in the next course number:");
                answer = Console.ReadLine();
                while (int.TryParse(answer, out number) == false)
                {
                    Console.WriteLine("You did not enter in a course number. Please try agian");
                    answer = Console.ReadLine();
                }
                courseNumber[i] = number;
            }

            //Output to the user the result of the course subject and the course number
            Console.WriteLine();
            for (int i = 0; i < courseName.Length; i++)
            {
                Console.WriteLine(courseName[i].ToUpper()+courseNumber[i]);
            }
        }
    }
}
