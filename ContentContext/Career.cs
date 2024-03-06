using System.Collections.Generic;

namespace Ead.Balta.ContentContext{
    public class Career:Content{
        public IList<CareerItem> Items {get;set;}
        public int TotalCourses => Items.Count;
                            //Expression body

        //Herdando de Content e usando as propriedades do pai no seu construtor
        public Career(string title, string url):base(title, url){
            Items = new List<CareerItem>();
        }
    }
}