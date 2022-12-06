// See https://aka.ms/new-console-template for more information


using Factory.CreditCardFactory;
using Factory.Factory;

ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinium");
if (cardDetails!=null)
{
    Console.WriteLine("CardType: "+cardDetails.GetCardType());
    Console.WriteLine("CreditLimit: "+cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge: "+cardDetails.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card Type");
}
Console.ReadLine();
