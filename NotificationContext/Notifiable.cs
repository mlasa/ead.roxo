using System;
using System.Linq;
using System.Collections.Generic;

namespace Balta.NotificationContext{
    /* Notifiable: Terá todas as notificações da aplicação.
    Todas as classes herdarão de Notifiable, para que as notificações 
    sejam globais, e não seja necessário criar um array destas em cada classe
    */

    /* Não haverá instâncias, mas pode ser herdada */
    public abstract class Notifiable{
        public List<Notification> Notifications {get; set;}
        public bool IsInvalid => Notifications.Any();

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification (Notification notification){
            Notifications.Add(notification);
        }
        public void AddNotifications (IEnumerable<Notification> notifications){
            Notifications.AddRange(notifications);
        }
    }
}