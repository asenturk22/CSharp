using _01_Intro.Business;
using _01_Intro.Entities;

namespace _01_Intro
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //variables --> camelCase
            string message = "Krediler";
            int term = 12;
            double amount = 1000;
            bool isAuthenticated = false;

            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C# Programlama";
            course1.Description = "C# Programlama kursu..";
            course1.Price = 10;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Pyton Programlama";
            course2.Description = "Python Programlama kursu..";
            course2.Price = 20;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Java Programlama";
            course3.Description = "Java Programlama kursu..";
            course3.Price = 30;

            Course[] courses = { course1, course2, course3 };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
            }

            CourseManager coursesManager = new CourseManager();
            Course[] courses2 = coursesManager.GetAll();
            for (int i = 0; i < courses2.Length; i++)
            {
                Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
            }

        }
    }
}