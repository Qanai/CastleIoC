using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credit
{
    public interface ICreditCard
    {
        string Charge();
        int ChargeCount { get; }
    }
}
