using System.Collections.Generic;
using Balta.ContentContext;

namespace Ead.Balta.ContentContext{
    public class Module:Base{
        public Module(){
            Lectures = new List<Lecture>();
        }

        public int Order {get;set;}
        public string Title {get;set;}
        public IList<Lecture> Lectures {get;set;}
    }
}