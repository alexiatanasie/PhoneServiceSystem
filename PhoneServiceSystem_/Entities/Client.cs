using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneServiceSystem_.Entities
{
    public class Client
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public List<ExtraOption> ExtraOptions { get; set; }

        public Client() {

            ExtraOptions = new List<ExtraOption>();
            Subscriptions=new List<Subscription>();
            Name = "";
        }
        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            
        }
    }
}
