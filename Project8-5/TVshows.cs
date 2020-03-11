using System;
using System.Collections.Generic;
using System.Text;

namespace Project8_5
{
    class Tvshows
    {
        public string FirstName;
        public string LastName;
        public string DateOfBirth;
        public string Address;
        public string City;
        public string State;
        public int ZipCode;
        public string PhoneNumber;
        public string Email;
        public bool isSubmitted;
        public bool isAccepted;


        public Tvshows(string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
               string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            isSubmitted = false;
            isAccepted = false;

        }   
        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been Submitted.");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application has been Accepted.");
        }
    }
}
