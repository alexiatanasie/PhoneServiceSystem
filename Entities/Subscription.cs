using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneServiceSystem_.Entities
{
    
    public enum SubType
    {
        Basic,Premium, Family, International,Business

    }
    [Serializable]
    public class Subscription
    {
        public int ClientId { get; set; } 
        public string Name { get; set; }
        public float MonthlyFee { get; set; }
        public DateTime RegistrationDate { get; set; }

        public SubType type { get; set; }
        public Subscription()
        {
            RegistrationDate = DateTime.Now;
        }
        public Subscription(int clientId,string name, float monthlyFee, DateTime registrationDate, SubType type)
        {
            ClientId = clientId;
           
            Name = name;
            MonthlyFee = monthlyFee;
            RegistrationDate = registrationDate;
            this.type = type;
            switch (type)
            {
                case SubType.Basic:
                    MonthlyFee = 13.55f;
                    break;
                case SubType.Premium:
                    MonthlyFee = 22.19f;
                    break;
                case SubType.Family:
                    MonthlyFee = 41.89f;
                    break;
                case SubType.International:
                    MonthlyFee = 60.29f;
                    break;
                case SubType.Business:
                    MonthlyFee = 72.74f;
                    break;
                default:
                    MonthlyFee = 0.0f;
                    break;
            }
        }
    } }