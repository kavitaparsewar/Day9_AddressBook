using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_AddressBook
{
    class UC3_edit
    {
        public string firstname, lastname, address, city, state, email;
        public string zipcode;
        public string phone;


        public static List<UC3_edit> People = new List<UC3_edit>();

        public static void editdetails()
        {
            UC3_edit person = new UC3_edit();

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


        public static void PrintDetails(UC3_edit person)
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


        public static void PrintingDetails(UC3_edit person)
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
        public static void All()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.\n");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("current list of people in your address book:\n");
            foreach (var person in People)
            {
                PrintingDetails(person);
            }
            Console.WriteLine("\nPress any key to continue.");
           
        }


        public static void Update()
        {
            Console.WriteLine("Press 1 If you want to edit any Contact in the Address Book");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the First Name of the Person U want to update");
                    string firstname = Console.ReadLine();

                    UC3_edit person = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
                    if (person == null)
                    {
                        Console.WriteLine(" not found");
                    }

                    Console.WriteLine("Are you sure you want to edit the person details from your address book? (Y/N)");
                    PrintingDetails(person);

                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Press 1 if u want to edit the LastName");
                        Console.WriteLine("Press 2 if u want to edit the Address");
                        Console.WriteLine("Press 3 if u want to edit the City");
                        Console.WriteLine("Press 4 if u want to edit the State");
                        Console.WriteLine("Press 5 if u want to edit the Zip Code");
                        Console.WriteLine("Press 6 if u want to edit the Phone Number");
                        Console.WriteLine("Press 7 if u want to edit the Email Id");

                        int ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Enter New LastName; ");
                                person.lastname = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Last Name: " + person.lastname);
                                break;
                            case 2:
                                Console.WriteLine("Enter New Address; ");
                                person.address = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Address: " + person.address);
                                break;
                            case 3:
                                Console.WriteLine("Enter New City: ");
                                person.city = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("City: " + person.city);
                                break;
                            case 4:
                                Console.WriteLine("Enter New State: ");
                                person.state = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("MobileNumber: " + person.state);
                                break;
                            case 5:
                                Console.WriteLine("Enter New ZipCode: ");
                                person.zipcode = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("ZipCode: " + person.zipcode);
                                break;
                            case 6:
                                Console.WriteLine("Enter New PhoneNumber: ");
                                person.phone = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("PhoneNumber: " + person.phone);
                                break;
                            case 7:
                                Console.WriteLine("Enter New Email ID: ");
                                person.email = Console.ReadLine();
                                People.Add(person);
                                Console.WriteLine("Email Id: " + person.email);
                                break;

                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        
                        Console.WriteLine("OKK. Press any key to continue.");
                    }
                    All();
                    break;
                       

           
            }

        }

    }
}
