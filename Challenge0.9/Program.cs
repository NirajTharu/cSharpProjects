// Complete a challenge to extract, replace, and remove data from an input string


using System;
namespace Challenge09
{
    class Program
    {
        static void Main(string[] args)
        {
            string quantity = "";
            string output = "";

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
            const string openSpan = "<span>";
            const string closeSpan = "</span>";
            int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
            int quantityEnd = input.IndexOf(closeSpan);
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);
            quantity = $"Quantity: {quantity}";


            const string openDiv = "<div>";
            const string closeDiv = "</div>";
            int openingPostion = input.IndexOf(openDiv);
            int closingPostion = input.IndexOf(closeDiv);
            openingPostion += openDiv.Length;
            int length = closingPostion - openingPostion;
            output = (input.Substring(openingPostion, length));

            const string tradeSymbol = "&trade;";
            const string registerSymbol = "&reg;";
            output = output.Replace(tradeSymbol, registerSymbol);
            output = $"Output: {output}";



            Console.WriteLine(quantity);
            Console.WriteLine(output);

        }
    }
}