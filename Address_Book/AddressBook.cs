using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddressBook
    {
        public void GotoContact()
        {
            while (true)
            {
                List<Contact> Contacts = new List<Contact>();

                Console.WriteLine("What you want to do? \n1: Add New Contact \n2: Display Record \n3: Edit details \n4: Delete Record \n0: Exit from the Address Book\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting From AddressBook");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Contacts.Add(new Contact());
                        Console.WriteLine("\nRecord added to the Contacts");
                        break;

                    case 2:
                        Console.WriteLine("\nEnter Name to Display details");
                        string dName = Console.ReadLine();

                        if (Contacts.Count != 0)
                        {
                            foreach (Contact contact in Contacts)
                            {
                                if (contact.getFName().Equals(dName))
                                {
                                    contact.DisplayRecord();
                                }
                                else
                                {
                                    Console.WriteLine("\nRecord not found");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nRecord not found try to create the new contact\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Name to Edit details");
                        string name = Console.ReadLine();

                        if (Contacts.Count != 0)
                        {
                            foreach (Contact contact in Contacts)
                            {
                                if (contact.getFName().Equals(name))
                                {
                                    contact.UpdateContact();
                                    Console.WriteLine("\nRecord updated in the Contacts");
                                }
                                else
                                {
                                    Console.WriteLine("\nYou are not in the Contacts");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not in the Contacts");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nEnter Name to Edit details");
                        string delname = Console.ReadLine();

                        if (Contacts.Count != 0)
                        {
                            foreach (Contact contact in Contacts)
                            {
                                if (contact.getFName().Equals(delname))
                                {
                                    Contacts.Remove(contact);
                                    Console.WriteLine("\nRecord deleted in the Contacts");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nYou are not in the Contacts");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nYou are not in the Contacts");
                        }
                        break;

                    default:
                        Console.WriteLine("\nEnter valid choice");
                        break;
                }
            }
        }
    }
}