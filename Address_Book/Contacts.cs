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

        public string getFName()
        {
            return firstName;
        }

        public string getLName()
        {
            return lastName;
        }
        public string getAddress()
        {
            return address;

        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }
        public string getZip()
        {
            return zip;
        }
        public string getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;

        }

        public Contact()
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



        public void UpdateContact()
        {

            Console.WriteLine("Previous First Name: " + this.firstName + "\nEnter First Name: ");
            this.firstName = Console.ReadLine();

            Console.WriteLine("Previous Last Name: " + this.lastName + "\nEnter Last Name: ");
            this.lastName = Console.ReadLine();

            Console.WriteLine("Previous Address: " + this.address + "\nEnter Address: ");
            this.address = Console.ReadLine();

            Console.WriteLine("Previous City: " + this.city + "\nEnter City: ");
            this.city = Console.ReadLine();

            Console.WriteLine("Previous State: " + this.state + "\nEnter State: ");
            this.state = Console.ReadLine(); ;

            Console.WriteLine("Previous Zip: " + this.zip + "\nEnter Zip: ");
            this.zip = Console.ReadLine();

            Console.WriteLine("Previous Phone: " + this.phone + "\nEnter PhoneNumber: ");
            this.phone = Console.ReadLine();

            Console.WriteLine("Previous Email: " + this.email + "\nEnter email: ");
            this.email = Console.ReadLine();

        }

        public void DisplayRecord()
        {
            Console.WriteLine("First Name: " + this.firstName);
            Console.WriteLine("Last Name: " + this.lastName);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("City: " + this.city);
            Console.WriteLine("State: " + this.state);
            Console.WriteLine("Zip: " + this.zip);
            Console.WriteLine("Phone: " + this.phone);
            Console.WriteLine("Email: " + this.email);
        }
    }
}