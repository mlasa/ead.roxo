using System;
using System.Collections.Generic;
using Ead.Balta.ContentContext;
namespace Ead.Balta;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine($"Hey Marcella aqui!- {new DateTime(2024,03,06).ToString("dd MMMM yy", new System.Globalization.CultureInfo("pt-BR"))}\n\n");
        
        //var course = new Course("Java com SpringBoot", "java-springboot");
        //Console.WriteLine($"Id do curso:{course.Id} / Nome do curso:{course.Title}");

        var articles = new List<Article>();
        articles.Add(new Article("Esse é o primeiro artigo!","meu-primeiro-artigo"));
        articles.Add(new Article("Porque o C# é uma ótima tecnologia","csharp-melhor-tecnologia"));

        var course = new Course("Fundamentos do C#", "fundamentos-csharp","fundamentos");
        var course1 = new Course("Fundamentos OO", "fundamentos-oo","fundamentos");
        var course2 = new Course("Fundamentos ASP NET", "fundamentos-aspnet","fundamentos");

        var courses = new List<Course>();
        courses.Add(course);
        courses.Add(course1);
        courses.Add(course2);

        var career = new Career("Especialista Dotnet", "especialista-dotnet");
        var careerItem = new CareerItem(1,"Entenda as bases do C#","Comece por aqui para ter noções da linguagem.", course);
        career.Items.Add(careerItem);

        /*foreach(var article in articles){
            Console.WriteLine($"Artigo:{article.Title} em /{article.Url}");
        }*/

        Console.WriteLine("\n\n");
    }
}
