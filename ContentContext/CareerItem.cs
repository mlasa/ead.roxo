using System.ComponentModel;

namespace Ead.Balta.ContentContext{
    public class CareerItem{
        public int Order {get;set;}
        public string Title {get;set;}
        public string Description {get;set;}
        public Course Course {get;set;}

        public CareerItem(int order,string title,string description,Course course)
        {
            if(course == null) throw new System.Exception("CarreerItem.cs - course não pode ser nulo");

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}