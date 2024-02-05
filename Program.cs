using System;

public class Program
{
    public static void Main(string[] args)
    {
        double number1 = 5.5; // variable med värdet 5.5    
        double number2 = 2.5; // variabel med värdet 2.5
        double result = Multi(number1, number2); // metoden multi har number1 och number2 som parametrar och resultatet har namnet result
        Console.WriteLine("Mulitplikationen gav" + result); // resultatet skrivs ut i konsolen

    }
    public static double Multi(double num1, double num2) // metod som tar två parametrar och geer deras produkt
{
    return num1 * num2;  //ger tilbaks deras produkt
}

}