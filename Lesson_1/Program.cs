using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет {0}", Environment.UserName + " " + "сегодня " + DateTime.Now);
        }
    }
}
