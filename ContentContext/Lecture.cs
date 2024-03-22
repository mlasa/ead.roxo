using Balta.ContentContext;
using Ead.Balta.ContentContext.Enums;

namespace Ead.Balta.ContentContext{
    public class Lecture:Base{
        public int Order {get;set;}
        public string Title {get;set;}
        public int DurationInMinutes {get; set;}
        public EContentLevel Level {get; set;}
    }
}