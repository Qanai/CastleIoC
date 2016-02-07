using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class Shopper
    {
        public ICreditCard CreditCard { get; set; }

        public int ChargesForCurrentCard { get { return CreditCard.ChargeCount; } }

        public string Charge()
        {
            return CreditCard.Charge();
        }

    }
}
