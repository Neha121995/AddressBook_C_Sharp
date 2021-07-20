using System;
using System.Collections.Generic;

namespace Address_Book
{
    class Program
    {
        public void Create_Contacts(Data contact)
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
            AdddressBookBuilder addressbook = new AdddressBookBuilder();
            Program addressbookobj = new Program();
            int choice = 1;
            while (choice != 4)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Menu : \n 1.Add Contact \n 2.Display Contact \n 3.Update Contact Using First Name \n 4.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Data contact = new Data();
                        addressbookobj.Create_Contacts(contact);
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
                            addressbookobj.Create_Contacts(contact2);
                            addressbook.list[index] = contact2;
                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                            Console.WriteLine("-----------After Updating---------");
                            Console.WriteLine($"First Name :{addressbook.list[index].First_Name} \nLast Name : {addressbook.list[index].Last_Name} \nAddress : {addressbook.list[index].Address} \nCity : {addressbook.list[index].City} \nState : {addressbook.list[index].State} \nZip : {addressbook.list[index].Zip} \nPhone No : {addressbook.list[index].Phone_No} \nEmail : {addressbook.list[index].Email}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Program Exited");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            }
        }
    }
}
