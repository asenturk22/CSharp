using _01_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Intro.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3];
        public CourseManager()
        {
            //Counstructor
            Course course4 = new Course();
            course4.Id = 1;
            course4.Name = "C# Programlama";
            course4.Description = "C# Programlama kursu..";
            course4.Price = 10;

            Course course5 = new Course();
            course5.Id = 2;
            course5.Name = "Pyton Programlama";
            course5.Description = "Python Programlama kursu..";
            course5.Price = 20;

            Course course6 = new Course();
            course6.Id = 3;
            course6.Name = "Java Programlama";
            course6.Description = "Java Programlama kursu..";
            course6.Price = 30;

            courses[0] = course4;
            courses[1] = course5;
            courses[2] = course6;            
        }
        public Course[] GetAll()
        {
            //Veriler veri kaynağından getirilir. 
            return courses;
        }
    }
}
