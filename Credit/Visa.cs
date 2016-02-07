using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class Visa : ICreditCard
    {

        public string Charge()
        {
            return "Visa... Visa";
        }

        public int ChargeCount
        {
            get { return 0; }
        }
    }
}
