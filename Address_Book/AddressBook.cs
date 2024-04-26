namespace Address_Book
{
    internal class AddressBook
    {
        internal static void Initialize()
        {
            List<Contacts> AddressBook = new List<Contacts>();

            while (true)
            {
                Console.WriteLine("What you want to do? \n1: Add New Contact \n0:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                switch (choice)
                {
                    case 1: AddressBook.Add(new Contacts()); break;
                    default: Console.WriteLine("Enter valid choice"); break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book. \n");

            Initialize();

        }
    }
}