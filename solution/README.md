# Lösning

Studera det kommenterade och kompletta lösningsförslaget i projektet **ContactableWebUsers**!

___Program.cs___

```c#
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
```

___Contact.cs___

```c#
using System;

namespace ContactableWebUsers
{
    class Contact
    {
        #region Fields

        // Always protect fields by using the 'private' access modifier!
        // These class members will then only be accessible within the  
        // class 'body' where they are declared.

        private DateTime _registrationDate; 

        // Since using autoimplemented properties for the contact's first name, 
        // last name and email address, no fields needs to be declared.
        // In these cases a private and anonymous underlying field, 
        // created by the compiler, is implied. It may only be 
        // accessed through respective property's get and set accessors.

        #endregion

        #region Constructors

        // This constructor with no arguments is the 'default constructor'
        // (sometimes also called "”no-arg constructor”").
        // It invokes the three-arguments constructor by using 'this' 
        // keyword, to initialize the class members with default values.
        public Contact()
            : this(string.Empty, string.Empty, string.Empty, DateTime.Today)
        {
            // Intentionally empty to avoid redundancy.
            // 'DRY' - Don't Repeat Yourself!
        }

        // A constructor with three arguments, invoking the four-arguments 
        // constructor to initialize class members with specified values. 
        public Contact(string firstName, string lastName, string emailAddress)
            : this(firstName, lastName, emailAddress, DateTime.Today)
        {
            // Intentionally empty to avoid redundancy.
            // 'DRY' - Don't Repeat Yourself!
        }

        // The four-arguments constructor finally initializes class
        // members with the values specified in current arguments.
        public Contact(string firstName, string lastName,
            string emailAddress, DateTime registrationDate)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            RegistrationDate = registrationDate;
        }

        #endregion

        #region Properties

        // Auto-Implemented Properties for cases of simple get and set.
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Also 'RegistrationDate' could have been declared as auto-property
        // but has been expanded as a clarifying alternative.
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }

        #endregion

        #region Overrides

        // Overriding the Object.ToString method to return a string 
        // which represents the current object instance.
        public override string ToString()
        {
            // Using 'string interpolation' expression:
            return $"{FirstName} {LastName}, {EmailAddress}, {RegistrationDate.ToShortDateString()}";
        }

        // Clarified alternative:
        //public override string ToString()
        //{
        //    return string.Format("{0} {1}, {2}, {3}",
        //        _firstName, _lastName, _emailAddress,
        //        _registrationDate.ToShortDateString());
        //}

        #endregion

    }
}

```