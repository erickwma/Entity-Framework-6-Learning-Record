using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advance = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();
            dbContext.GetCourses();
            var courses = dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }
            var myCourse = new Course();
            myCourse.Level = CourseLevel.Beginner;
        }
    }
}
