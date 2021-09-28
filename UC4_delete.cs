using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day9_AddressBook
{
    class UC4_delete
    {
        public string firstname,lastname,address,city,state,email;
        public string zipcode;
        public string phone;
        

        public static List<UC4_delete> People = new List<UC4_delete>();

        public static void createnew()
        {
            UC4_delete person = new UC4_delete();

            Console.WriteLine("Enter First Name: ");
            person.firstname = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            person.lastname = Console.ReadLine();

            Console.WriteLine("Enter the Address: ");
            person.address = Console.ReadLine();

            Console.WriteLine("Enter City  ");
            person.city = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            person.state = Console.ReadLine();

            Console.WriteLine("Enter the Zip Code: ");
            person.zipcode = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            person.phone = Console.ReadLine();

            Console.WriteLine("Enter the Email ID: ");
            person.email = Console.ReadLine();


            People.Add(person);
        }


        public static void PrintDetails(UC4_delete person)
        {
            Console.WriteLine("First Name: " + person.firstname);
            Console.WriteLine("Last Name: " + person.lastname);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip Code: " + person.zipcode);
            Console.WriteLine("Phone Number: " + person.phone);
            Console.WriteLine("Email ID: " + person.email);
        }

        public static void Contacts()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("current list of people in your address book:\n");
            foreach (var person in People)
            {
                PrintDetails(person);
            }
            Console.WriteLine("\n Enter any key to continue.");
            

        }

        public static void deletePerson()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove:");
            string firstname = Console.ReadLine();


            UC4_delete findperson = People.FirstOrDefault(x => x.firstname.ToLower() == firstname.ToLower());
            if (findperson == null)
            {
                Console.WriteLine("not found");
            }

            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintDetails(findperson);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(findperson);
                Console.WriteLine("\n Person removed.");
                Console.ReadKey();
            }
            Contacts();
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.WriteLine("\n OK.");
            }

        }
    }
}
