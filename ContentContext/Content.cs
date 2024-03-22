using System;
using Balta.ContentContext;

namespace Ead.Balta.ContentContext{

    /*
        Todos os tipos de conteúdo tem algumas propriedades em comum,
         então Content será a classe base de qual os tipos de conteúdos herdarão.
    */
    public class Content:Base{
        public Content(string title, string url){
            Title = title;
            Url = url;
        }

        public string Title {get; set;}
        public string Url {get; set;}
    }
}