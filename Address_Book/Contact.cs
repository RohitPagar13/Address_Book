using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string bookName { get; set; }

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

        public string getBookName()
        {
            return bookName;
        }

        public Contact()
        {

        }

        public Contact(string firstName, string bookName)
        {

            this.firstName = firstName;

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

            this.bookName = bookName;

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

        public override string ToString()
        {
            return "AddressBook Name: "+ bookName+ ", First Name: " + firstName+ ", Last Name: "+lastName+ ", Address: "+address+", City: "+city+", State: "+state+", Zip: "+zip+", Phone No.: "+phone+", Email: "+email;
        }


        
    }
}