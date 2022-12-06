using Factory.Factory.implementation;
using Factory.Product;

ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{

    Console.WriteLine("CardType: " + creditCard.GetCardType());
    Console.WriteLine("CreditLimit: " + creditCard.GetCreditLimit());
    Console.WriteLine("AnnualCharge: " + creditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.ReadLine();