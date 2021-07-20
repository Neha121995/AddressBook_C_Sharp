using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AdddressBookBuilder
    {
        public List<Data> list;
        public AdddressBookBuilder()
        {
            this.list = new List<Data>();
        }
        public void AddContact(Data dataobj)
        {
            this.list.Add(dataobj);
        }
        public void Display_Contacts()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------Contacts in Address Books System--------------");

            foreach (var i in this.list)
            {
                Console.WriteLine($"{i.First_Name} : {i.Last_Name} : {i.Address} : {i.City} : {i.State} : {i.Zip} : {i.Phone_No} : {i.Email}");
            }
        }
    }
}
