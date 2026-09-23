using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel
{
    public class Person
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }


        public Person(string name, string mail, string phone)
        {
            Name = name;
            Mail = mail;
            PhoneNumber = phone;
        }


    }
    
}
