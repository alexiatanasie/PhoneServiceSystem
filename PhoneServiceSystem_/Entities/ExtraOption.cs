using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneServiceSystem_.Entities
{
    public class ExtraOption
    {
        public int ExtraOptionId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public SubTypee TypeExtraOption { get; set; }    
        public enum SubTypee
        {
            InternationalMinutes, PrivacyServices, AccidentalDamageProtectionInsurance
        }
        public ExtraOption() { }
        public ExtraOption(int extraOptionId, string name, double price, SubTypee typeExtraOption) 
        {
            ExtraOptionId = extraOptionId;
            Name = name;
            Price = price;
            this.TypeExtraOption = typeExtraOption;

            switch (typeExtraOption)
            {
                case SubTypee.InternationalMinutes:
                    ExtraOptionId = 1;
                    Price = 9.99;
                    break;
                case SubTypee.PrivacyServices:
                    ExtraOptionId = 2;
                    Price = 13.90;
                    break;
                case SubTypee.AccidentalDamageProtectionInsurance:
                    ExtraOptionId = 3;
                    Price = 22.99;
                    break;
                default:
                    ExtraOptionId = extraOptionId;
                    Price = price;
                    break;
            }
        }
        
    }
}
