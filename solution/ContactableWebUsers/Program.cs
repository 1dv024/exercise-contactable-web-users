using System;

namespace ContactableWebUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using 'default constructor' for first object
            Contact contact1 = new Contact();
            Contact contact2 = new Contact("Nisse", "Hult", "nisse.hult@ploj.se");
            Contact contact3 = new Contact("Adam", "Bertilsson",
                "progace@anywhere.com", DateTime.Today.AddMonths(6));

            // Setting properties for first object
            contact1.FirstName = "David";
            contact1.LastName = "Eriksson";
            contact1.EmailAddress = "dv47@coldmail.com";
            contact1.RegistrationDate = DateTime.Parse("2007-12-24");

            // Invoking toString() method for each Contact instance:
            Console.WriteLine(contact1);
            Console.WriteLine(contact2);
            Console.WriteLine(contact3);
        }
    }
}
