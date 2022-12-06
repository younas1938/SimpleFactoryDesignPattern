using Factory.CreditCardFactory;
using Factory.Product.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType.ToLower() == "moneyback")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType.ToLower() == "titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType.ToLower() == "platinium")
            {
                cardDetails = new Platinium();
            }
            return cardDetails;
        }
    }
}
