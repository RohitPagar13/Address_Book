namespace Address_Book
{
    internal class AddressBook
    {
        internal static void Initialize()
        {
            List<Contacts> AddressBook = new List<Contacts>();

            while (true)
            {
                Console.WriteLine("What you want to do? \n1: Add New Contact \n2: Display Record \n3: Edit details \n4: Delete Record \n0: Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        AddressBook.Add(new Contacts());
                        Console.WriteLine("\nRecore added to the AddressBook");
                        break;

                    case 2:
                        Console.WriteLine("\nEnter Name to Display details");
                        string dName = Console.ReadLine();

                        if (AddressBook.Count != 0)
                        {
                            foreach (Contacts contacts in AddressBook)
                            {
                                if (contacts.getFName().Equals(dName))
                                {
                                    contacts.DisplayRecord();
                                }
                                else
                                {
                                    Console.WriteLine("\nYou are not in the AddressBook");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not in the AddressBook\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Name to Edit details");
                        string name = Console.ReadLine();

                        if (AddressBook.Count != 0)
                        {
                            foreach (Contacts contacts in AddressBook)
                            {
                                if (contacts.getFName().Equals(name))
                                {
                                    contacts.UpdateContact();
                                    Console.WriteLine("\nRecord updated in the AddressBook");
                                }
                                else
                                {
                                    Console.WriteLine("\nYou are not in the AddressBook");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not in the AddressBook");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nEnter Name to Edit details");
                        string delname = Console.ReadLine();

                        if (AddressBook.Count != 0)
                        {
                            foreach (Contacts contacts in AddressBook)
                            {
                                if (contacts.getFName().Equals(delname))
                                {
                                    AddressBook.Remove(contacts);
                                    Console.WriteLine("\nRecord deleted in the AddressBook");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nYou are not in the AddressBook");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not in the AddressBook");
                        }
                        break;

                    default:
                        Console.WriteLine("\nEnter valid choice");
                        break;
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