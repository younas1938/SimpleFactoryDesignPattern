// See https://aka.ms/new-console-template for more information

string cardType = "MoneyBack";
ICreditCard cardDetails= null;

if (cardType.ToLower()=="moneyback")
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
if (cardDetails!=null)
{
    Console.WriteLine("CardType: "+ cardDetails.GetCardType());
    Console.WriteLine("CreditLimits: : "+ cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge: "+ cardDetails.GetAnnualCharge());
}
public interface ICreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}

class MoneyBack : ICreditCard
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
class Titanium : ICreditCard
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
class Platinium : ICreditCard
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