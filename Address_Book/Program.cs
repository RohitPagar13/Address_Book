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


                Console.WriteLine("\nWhat you want to do? \n1: Add New AddressBook \n2: Want to Add/Update contact to the AdressBook \n3: Want to Search person by their City \n4: count of persons in all cities \n5: View all persons by cities \n0: Exit from the System\n");
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
                        if (bookName1 == null)
                        {
                            Console.WriteLine("\nEnter Valid Name of the AddressBook");
                        }
                        else
                        {
                            AddressBook AddressBook = addressBooks[bookName1];
                            AddressBook.GotoContact();
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Name of the city: ");
                        string City = Console.ReadLine();
                        List<Contact> Contacts = SearchByCity(City);
                        Console.WriteLine("");
                        Console.WriteLine("\nBelow is the list of the names of the persons from " + City + " in multiple Address Books");
                        foreach (Contact contact in Contacts)
                        {
                            Console.WriteLine(contact.getFName);
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nBelow is the List of cities with count of persons in that city");
                        countByCity();
                        break;

                    case 5:
                        Console.WriteLine("List of persons by city: ");

                        foreach (var ob in ViewPersonsByCity())
                        {
                            int c = 0;
                            Console.WriteLine("\n" + ob.Key);
                            foreach (Contact contact in ob.Value)
                            {
                                c++;
                                Console.WriteLine(c + ". " + contact);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Enter Valid choice");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book. \n");

            GotoAddressBook();
        }
    }
}