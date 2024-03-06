namespace Ead.Balta.ContentContext{
    public class Article:Content{
        //Herdando de Content e usando as propriedades do pai no seu construtor
        public Article(string title, string url):base(title, url){}
    }
}