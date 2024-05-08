using System;
using System.Collections.Generic;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace Address_Book
{
    internal class Program
    {
        static Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
        public static List<Contact> SearchByCity(string City)
        {
            List <Contact> allContacts = new List<Contact>();
            
            foreach (var addressBook in addressBooks)
            {
                foreach (Contact contact in addressBook.Value.getContactList())
                {
                    if (contact.getCity().Equals(City))
                    {

                        allContacts.Add(contact);
                    }
                }
            }
            return allContacts;
        }

        public static Dictionary<string, List<Contact>> ViewPersonsByCity()
        {
            Dictionary<string, List<Contact>> Persons = new Dictionary<string, List<Contact>>();
            List<string> cities = ListAllCities();

            for (int i=0; i<cities.Count; i++)
            {
                Persons.Add(cities[i], SearchByCity(cities[i]));
            }
            return Persons;

        }

        public static List<string> ListAllCities()
        {
            List<string> cities = new List<string>();
            foreach (var addressBook in addressBooks)
            {
                foreach (Contact contact in addressBook.Value.getContactList())
                {
                    if (!cities.Contains(contact.getCity()))
                    {
                        cities.Add(contact.getCity());
                    }
                }
            }
            return cities;
        }

        

        public static void countByCity()
        {
            List<string> cities = ListAllCities();
            int count;
            for (int i = 0; i < cities.Count; i++)
            {
                count = 0;
                foreach (var addressBook in addressBooks)
                {
                    foreach (Contact contact in addressBook.Value.getContactList())
                    {
                        if (contact.getCity().Equals(cities[i]))
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine("City: " + cities[i] + " Count:" + count);
            }
        }
        static void GotoAddressBook()
        {

            while (true)
            {


                Console.WriteLine("\nWhat you want to do? \n1: Add New AddressBook \n2: Want to Add/Update contact to the AdressBook \n3: Want to Search person by their City \n4: count of persons in all cities \n5: View all persons by cities \n6: write data to the file \n7: read data from file \n8: write data to the CSV \n9: Read data from the CSV \n10: write data to the JSON \n11: Read data from the JSON \n0: Exit from the System\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("\nExiting from System");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Name of the AddressBook");
                        string bookName = Console.ReadLine();
                        if (bookName == null)
                        {
                            Console.WriteLine("\nBook Name cannot be null");
                        }
                        else
                        {
                            if (addressBooks.ContainsKey(bookName))
                            {
                                Console.WriteLine("\nAddress book name already exists.");
                            }
                            else
                            {
                                addressBooks.Add(bookName, new AddressBook());
                                Console.WriteLine("\nAddressBook added to the System\n");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nEnter Name of the AddressBook");
                        string bookName1 = Console.ReadLine();
                        if (bookName1 == null )
                        {
                            Console.WriteLine("\nEnter Valid Name of the AddressBook");
                        }
                        else if (!addressBooks.ContainsKey(bookName1))
                        {
                            Console.WriteLine("Address book does not exists");
                        }
                        else
                        {
                            AddressBook AddressBook = addressBooks[bookName1];
                            AddressBook.GotoContact(bookName1);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Name of the city: ");
                        string City = Console.ReadLine();
                        List<Contact> Contacts = SearchByCity(City);
                        Console.WriteLine("");
                        if (Contacts != null)
                        {
                            Console.WriteLine("\nBelow is the list of the names of the persons from " + City + " in multiple Address Books");
                            foreach (Contact contact in Contacts)
                            {
                                Console.WriteLine(contact.getFName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact found");
                        } 
                        
                        break;

                    case 4:
                        Console.WriteLine("\nBelow is the List of cities with count of persons in that city");
                        countByCity();
                        break;

                    case 5:
                        Dictionary<string, List<Contact>> persons = ViewPersonsByCity();
                        Console.WriteLine("List of persons by city: ");

                        if (persons != null)
                        {
                            foreach (var ob in persons)
                            {
                                int c = 0;
                                Console.WriteLine("\n" + ob.Key);
                                foreach (Contact contact in ob.Value)
                                {
                                    c++;
                                    Console.WriteLine(c + ". " + contact);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Their are no persons in the AddressBook");
                        }
                        
                        break;

                    case 6:
                        Write();
                        Console.WriteLine("Data added to the file");
                        break;

                    case 7:
                        Console.WriteLine("Below is the data from the file:\n");
                        Read();
                        break;

                    case 8:
                        WriteDataToCsv();
                        break;

                    case 9:
                        Console.WriteLine("Below is the data from the file:\n");
                        ReadDataFromCsv();
                        break;

                    case 10:
                        WriteDataToJSON();
                        break;

                    case 11:
                        Console.WriteLine("Below is the data from the file:\n");
                        ReadDataFromJSON();
                        break;

                    default:
                        Console.WriteLine("Enter Valid choice");
                        break;
                }
            }
        }

        public static void Write()
        {
            string filepath = "E:\\BridgeLabz\\Address_Book\\fileIO\\contactList.txt";

            using (StreamWriter sw = new StreamWriter(filepath))
            {
                foreach (var addressBook in addressBooks)
                {
                    foreach (Contact contact in addressBook.Value.getContactList())
                    {
                        sw.WriteLine(contact.ToString());
                    }
                }
            }
        }

        public static void Read()
        {
            List<Contact> list = new List<Contact>();
            string filepath = "E:\\BridgeLabz\\Address_Book\\fileIO\\contactList.txt";

            using (StreamReader sr = File.OpenText(filepath))
            {
                string line;
                while((line=sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void ReadDataFromCsv()
        {
            string filepath = "E:\\BridgeLabz\\Address_Book\\CSV\\contactList.csv";
            
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ContactMap>();
                var contacts = csv.GetRecords<Contact>().ToList();
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine($"Book Name: {contact.bookName}, First Name: {contact.firstName}, Last Name: {contact.lastName}, Address: {contact.address}, City: {contact.city}, State: {contact.state}, Zip: {contact.zip}, Phone: {contact.phone}, Email: {contact.email}");
                }
            }
        }

        public static void WriteDataToCsv()
        {

            try
            {
                string filepath = "E:\\BridgeLabz\\Address_Book\\CSV\\contactList.csv";
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true
                };

                using (StreamWriter writer = new StreamWriter(filepath))
                using (CsvWriter csv = new CsvWriter(writer, csvConfig))
                {
                    csv.WriteRecords(addressBooks.SelectMany(addressBook => addressBook.Value.getContactList()));
                    writer.Flush();
                }

                System.Console.WriteLine("Address book has been written to CSV file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            
        }

        public static void ReadDataFromJSON()
        {
            string filepath = "E:\\BridgeLabz\\Address_Book\\JSON\\contactList.json";

            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Contact c = JsonConvert.DeserializeObject<Contact>(line);
                    Console.WriteLine(c);
                }
            }
        }

        public static void WriteDataToJSON()
        {

            try
            {
                string filepath = "E:\\BridgeLabz\\Address_Book\\JSON\\contactList.json";
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach (var addressBook in addressBooks)
                    {
                        foreach(var contact in addressBook.Value.getContactList())
                        {
                            string json = JsonConvert.SerializeObject(contact);
                            sw.WriteLine(json);
                        }
                    }
                    System.Console.WriteLine("Address book has been written to JSON file.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book. \n");

            GotoAddressBook();
        }
    }
}