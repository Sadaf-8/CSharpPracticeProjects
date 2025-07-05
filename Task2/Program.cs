using System;
namespace CSharpConsoleAppWithUserInput
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Grade: ");
            char Grade = char.Parse(Console.ReadLine());

            Console.WriteLine("Student Status true/false: ");
            bool IsStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"\nAge: {Age}");
            Console.WriteLine($"\nHeight: {height}");
            Console.WriteLine($"\nGrade: {Grade}");
            Console.WriteLine($"\nStudent Status: {IsStudent}");


        }
    }
}
