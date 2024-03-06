using System;
using Ead.Balta.ContentContext;
namespace Ead.Balta;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        var course = new Course("Java com SpringBoot", "java-springboot");
        Console.WriteLine($"Id do curso:{course.Id} / Nome do curso:{course.Title}");
    }
}
