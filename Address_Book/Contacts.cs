using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contacts
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;


        public Contacts()
        {

            Console.WriteLine("Enter First Name: ");
            this.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            this.lastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            this.address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            this.city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            this.state = Console.ReadLine(); ;

            Console.WriteLine("Enter Zip: ");
            this.zip = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber: ");
            this.phone = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            this.email = Console.ReadLine();

        }
    }
}