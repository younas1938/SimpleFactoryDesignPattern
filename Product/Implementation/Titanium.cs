using Factory.CreditCardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Product.Implementation
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}
