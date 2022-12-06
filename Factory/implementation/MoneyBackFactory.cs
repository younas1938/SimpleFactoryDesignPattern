using Factory.Product;
using Factory.Product.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.implementation
{
    internal class MoneyBackFactory :CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        ICreditCard product = new MoneyBack();
        return product;
    }
}
}
