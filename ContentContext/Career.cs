namespace Ead.Balta.ContentContext{
    public class Career:Content{
        //Herdando de Content e usando as propriedades do pai no seu construtor
        public Career(string title, string url):base(title, url){}
    }
}