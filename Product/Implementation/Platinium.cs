using Factory.CreditCardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Product.Implementation
{
    public class Platinium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinium Plus";
        }

        public int GetCreditLimit()
        {
            return 75000;
        }
    }
}
