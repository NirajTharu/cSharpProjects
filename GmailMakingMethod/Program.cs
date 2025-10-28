/*In the code you start with, there are two arrays for internal and external employees.
Remember, the domain for internal employees is "contoso.com"
and the username for all employees is the first two characters of their first name, followed by their full last name*/
using System;
namespace MailMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] corporate = { { "Robert", "Bavin" }, { "Simon", "Bright" }, { "Kim", "Sinclair" }, { "Aashrita", "Kamath" }, { "Sarah", "Delucchi" }, { "Sinan", "Ali" } };

            string[,] external = { { "Vinnie", "Ashton" }, { "Cody", "Dysart" }, { "Shay", "Lawrence" }, { "Daren", "Valdes" } };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                DisplayEmail(firstName: corporate[i, 0], lastName: corporate[i, 1]);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                DisplayEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
            }

            void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
            {
                string email = firstName.Substring(0, 2) + lastName;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }
        }
    }
}
