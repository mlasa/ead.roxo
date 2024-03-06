using System.Reflection;

namespace Ead.Balta.ContentContext{
    public class Course:Content{
        //Herdando de Content e usando as propriedades do pai no seu construtor
        public Course(string title, string url):base(title, url){}
    }
}