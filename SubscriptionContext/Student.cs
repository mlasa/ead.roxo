using System.Collections.Generic;
using System.Linq;
using Balta.SharedContext;
using Flunt.Notifications;

namespace Balta.SubscriptionContext{
    public class Student:Base{
        public string Name {get; set;}
        public string Email {get; set;}
        public User User {get; set;}
        public IList<Subscription> Subscriptions {get; set;}
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive );

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public void CreateSubscription (Subscription subscription){
            if(IsPremium){
                AddNotification(new Notification("Premium", "Aluno já possui assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}