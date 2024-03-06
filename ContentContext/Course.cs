using System;
using System.Collections.Generic;

namespace Ead.Balta.ContentContext{
    public class Course:Content{
        public string Tag {get;set;}
        public IList<Module> Modules { get; set; }

        //Herdando de Content e usando as propriedades do pai no seu construtor
        public Course(string title, string url, string tag)
        :base(title, url)
        {
            Modules = new List<Module>();
            Tag = tag;
        }
    }
}