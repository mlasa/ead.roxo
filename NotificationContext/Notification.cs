namespace Balta.NotificationContext{
    /*
        Notification: classe para notificação de erros, para não travar o
        programa em uma Exception.

        Classe não pode ser extendida, não haverá variações dessa classe.
        Porém posso criar instâncias.
        Será uma classe padronizada para todo o sistema.
    */
    public sealed class Notification{
        /*Para caso o desenvolvedor não queira passar os dados*/
        public Notification(){}
        public Notification(string property, string message){
            Property = property;
            Message = message;
        }

        public string Property {get; set;}
        public string Message {get; set;}
    }
}