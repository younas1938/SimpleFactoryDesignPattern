using Factory.CreditCardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Product.Implementation
{
    public class MoneyBack : ICreditCard
{
    public int GetAnnualCharge()
    {
        return 300;
    }

    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCreditLimit()
    {
        return 25000;
    }
}
}
