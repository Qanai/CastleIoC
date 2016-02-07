using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class ShopperVer1
    {
        private readonly ICreditCard creditCard;

        public int ChargesForCurrentCard
        {
            get { return creditCard.ChargeCount; }

        }

        public ShopperVer1(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public string Charge()
        {
            return creditCard.Charge();
        }
    }
}
