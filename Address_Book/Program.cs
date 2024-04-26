namespace Address_Book
{
    internal class Program
    {

        static void GotoAddressBook()
        {
            Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
            while (true)
            {


                Console.WriteLine("What you want to do? \n1: Add New AddressBook \n2: Want to Add/Update contact to the AdressBook \n0: Exit from the System\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting from System");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name of the AddressBook");
                        string bookName = Console.ReadLine();
                        if (bookName == null)
                        {
                            Console.WriteLine("Book Name cannot be null");
                        }
                        else
                        {
                            if (addressBooks.ContainsKey(bookName))
                            {
                                Console.WriteLine("Address book name already exists.");
                            }
                            else
                            {
                                addressBooks.Add(bookName, new AddressBook());
                                Console.WriteLine("\nAddressBook added to the System\n");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Name of the AddressBook");
                        string bookName1 = Console.ReadLine();
                        if (bookName1 == null)
                        {
                            Console.WriteLine("Enter Valid Name of the AddressBook");
                        }
                        else
                        {
                            AddressBook AddressBook = addressBooks[bookName1];
                            AddressBook.GotoContact();
                        }
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