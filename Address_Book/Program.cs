namespace Address_Book
{
    internal class Program
    {
        static Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
        public static void SearchByCity(string City)
        {
            Console.WriteLine("\nBelow is the list of the names of the persons from same city in multiple Address Books");
            foreach (var addressBook in addressBooks)
            {
                foreach (Contact contact in addressBook.Value.getContactList())
                {
                    if (contact.getCity().Equals(City))
                    {

                        Console.WriteLine(contact.getFName());
                    }
                }
            }
        }

        public static void ViewPersonsByCity()
        {
            Console.WriteLine("List of persons by city");
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
                        cities.Add(contact.getFName());
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


                Console.WriteLine("\nWhat you want to do? \n1: Add New AddressBook \n2: Want to Add/Update contact to the AdressBook \n3: Want to Search person by their City \n0: Exit from the System\n");
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
                        Console.WriteLine("\nEnter Name of the city");
                        SearchByCity(Console.ReadLine());
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