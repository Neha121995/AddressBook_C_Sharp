using System;
using System.Collections.Generic;

namespace Address_Book
{
    class Program
    {
        public static Dictionary<string, AdddressBookBuilder> AddressBookDictionary = new Dictionary<string, AdddressBookBuilder>();
        public static void FillAddressBook(AdddressBookBuilder addressbook)
        {
            int choice = 1;

            while (choice != 5)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Menu : \n 1.Add Contact \n 2.Display Contact \n 3.Update Contact Using First Name \n 4.Delete Contact using first Name \n 5.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Data contact = new Data();
                        Create_Contacts(contact);
                        addressbook.AddContact(contact);
                        Console.WriteLine("Contact Added Successfully.");
                        break;
                    case 2:
                        addressbook.Display_Contacts();
                        break;
                    case 3:
                        Console.WriteLine("which contact you want to update Enter First Name");
                        String FirstName = (Console.ReadLine());
                        int index = addressbook.Update_Contact(FirstName);
                        Console.WriteLine("Index is " + index);
                        if (index == -1)
                        {
                            Console.WriteLine("Contact Not Found");
                        }
                        else
                        {
                            Data contact2 = new Data();
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Console.WriteLine("-----------Before Updating-----------");
                            Console.WriteLine($"First Name :{addressbook.list[index].First_Name} \nLast Name : {addressbook.list[index].Last_Name} \nAddress : {addressbook.list[index].Address} \nCity : {addressbook.list[index].City} \nState : {addressbook.list[index].State} \nZip : {addressbook.list[index].Zip} \nPhone No : {addressbook.list[index].Phone_No} \nEmail : {addressbook.list[index].Email}");
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Create_Contacts(contact2);
                            addressbook.list[index] = contact2;
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Console.WriteLine("-----------After Updating---------");
                            Console.WriteLine($"First Name :{addressbook.list[index].First_Name} \nLast Name : {addressbook.list[index].Last_Name} \nAddress : {addressbook.list[index].Address} \nCity : {addressbook.list[index].City} \nState : {addressbook.list[index].State} \nZip : {addressbook.list[index].Zip} \nPhone No : {addressbook.list[index].Phone_No} \nEmail : {addressbook.list[index].Email}");
                            Console.WriteLine("Contact Update Successfully.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("which contact you want to Delete Enter First Name");
                        String First_Name = (Console.ReadLine());
                        int index1 = addressbook.Update_Contact(First_Name);
                        Console.WriteLine("Index is " + index1);
                        if (index1 == -1)
                        {
                            Console.WriteLine("Contact Not Found");
                        }
                        else
                        {
                            Data contact2 = new Data();
                            addressbook.list.RemoveAt(index1);
                            Console.WriteLine("Contact Delete Successfully.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Program Exited");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            }
        }
        public static void Create_Contacts(Data contact)
        {
            Console.Write("Enter the First Name : ");
            contact.First_Name = (Console.ReadLine());

            Console.Write("Enter the Last Name : ");
            contact.Last_Name = (Console.ReadLine());

            Console.Write("Enter the Address : ");
            contact.Address = (Console.ReadLine());

            Console.Write("Enter the City : ");
            contact.City = (Console.ReadLine());

            Console.Write("Enter the State : ");
            contact.State = (Console.ReadLine());

            Console.Write("Enter the Zip : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Phone No : ");
            contact.Phone_No = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Email Id : ");
            contact.Email = (Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            int choice = 1;

            while (choice != 3)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Menu : \n 1.Add new Address Book name \n 2.Work in existing address book \n 3.exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter New address book name : ");
                        String Name = (Console.ReadLine());
                        AddressBookDictionary.Add(Name, new AdddressBookBuilder());
                        break;

                    case 2:
                        Console.Write("In which address book you want to work : ");
                        String name = (Console.ReadLine());
                        AdddressBookBuilder addressbook = AddressBookDictionary[name];
                        FillAddressBook(addressbook);
                        break;

                    case 3:
                        Console.WriteLine("Program is terminated");
                        break;

                    default:
                        Console.WriteLine("Your input is wrong");
                        break;
                }
            }

        }
    }
}
