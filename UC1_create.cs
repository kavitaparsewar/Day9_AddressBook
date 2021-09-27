using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_AddressBook
{
    class UC1_create
    {
        public string fname, lname, addr, city, state, email;
        public static void Book()
        {
            UC1_create b = new UC1_create();

            Console.WriteLine("Enter first name : ");
            b.fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            b.lname = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            b.addr = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            b.city = Console.ReadLine();

            Console.WriteLine("Enter state: ");
            b.state = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            b.email = Console.ReadLine();

            Console.WriteLine("Enter zip");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone number");
            int phone = Convert.ToInt32(Console.ReadLine());


        }
    }
}
