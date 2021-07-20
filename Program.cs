using System;

namespace Address_Book
{
    class Program
    {
        String First_Name, Last_Name, Address, City, State;
        int Zip;
        long Phone_No;
        public void Create_Contacts()
        {
            Console.Write("Enter the First Name : ");
            First_Name = (Console.ReadLine());

            Console.Write("Enter the Last Name : ");
            Last_Name = (Console.ReadLine());

            Console.Write("Enter the Address : ");
            Address = (Console.ReadLine());

            Console.Write("Enter the City : ");
            City = (Console.ReadLine());

            Console.Write("Enter the State : ");
            State = (Console.ReadLine());

            Console.Write("Enter the Zip : ");
            Zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Phone No : ");
            Phone_No = Convert.ToInt64(Console.ReadLine());
        }

        public void Display_Contacts()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------Contacts in Address Books System--------------");
            Console.WriteLine("First name is :" + First_Name + "\nLast name is :" + Last_Name + "\nAddress is :" + Address + "\nCity is :" + City + "\nState is :" + State + "\nZip code is :" + Zip + "\nPhone no is :" + Phone_No);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Program addressbookpbj = new Program();
            addressbookpbj.Create_Contacts();
            addressbookpbj.Display_Contacts();

        }
    }
}
