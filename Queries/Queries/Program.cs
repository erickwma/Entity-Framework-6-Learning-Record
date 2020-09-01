using System.Linq;

using System;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //// LINQ syntax
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("c#")
            //    orderby c.Name
            //    select c;
            //foreach (var course in query)
            //    Console.WriteLine(course.Name);

            //// Extension methods

            //    .Where(c => c.Name.Contains("c#"))
            //    .OrderBy(c => c.Name);

            //foreach (var course in courses)
            //    Console.WriteLine(course.Name);

            //LINQ Syntax


            //Restriction
            //var query =
            //    from c in context.Courses
            //    where c.Level == 1 && c.Author.Id == 1
            //    select c;

            //Ordering
            //var query =
            //    from c in context.Courses
            //    where c.Author.Id == 1
            //    orderby c.Level descending, c.Name
            //    select c;

            //Projection
            //var query =
            //    from c in context.Courses
            //    where c.Author.Id == 1
            //    orderby c.Level descending, c.Name
            //    select new { Name = c.Name, Author = c.Author.Name };

            //Grouping
            var query =
            from c in context.Courses
            group c by c.Level
            into g
            select g;

            foreach (var group in query)
            {
                Console.WriteLine("{0} ({1})", group.Key, group.Count());

                //foreach (var course in group)
                //    Console.WriteLine("\t{0}", course.Name);
            }

        }
    }
}
