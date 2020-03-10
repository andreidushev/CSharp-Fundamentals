using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Courses
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string course = arg[0];
                string student = arg[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course,new List<string>());
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }
                
            }
            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var name in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
