using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_AddressBook
{
    class UC2_addnew
    {
        public string fname, lname, addr, city, state, email;

        public static void Book1()
        {

            List<UC2_addnew> record = new List<UC2_addnew>();
            UC2_addnew b = new UC2_addnew();

            Console.WriteLine("Enter first Name: ");
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

            Console.WriteLine("Enter zip:");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone number:");
            int phone = Convert.ToInt32(Console.ReadLine());

            record.Add(b);
        }

        public static void Print()
        {

            UC2_addnew b = new UC2_addnew();

            Console.WriteLine("Enter first Name: ");
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

            Console.WriteLine("Enter zip:   ");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone number:  ");
            int phone = Convert.ToInt32(Console.ReadLine());


        }
    }
}
