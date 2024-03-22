using System;
using System.Collections.Generic;
using System.Text.Json;
using Balta.SubscriptionContext;
using Ead.Balta.ContentContext;
namespace Ead.Balta;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine($"Heyyy, projeto rodando! - {DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("pt-BR"))}\n\n");
        
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
        var careerItem2 = new CareerItem(1,"Conhecendo os Objetos","", course2);

        career.Items.Add(careerItem);
        career.Items.Add(careerItem2);

        var payPalSub = new PayPalSubscription();
        var student = new Student();
        /*upcast*/
        student.Subscriptions.Add(payPalSub);

        Console.WriteLine("\n");
    }
}
