using System;
using System.Collections.Generic;
using System.Text;

namespace Project8_5
{
    class ParadiseIsland : Tvshows
    {


        public string Gender;
        public string NameOfSignificatOther;
        public int YearsDating;

        public ParadiseIsland(string Gender, string NameOfSignificatOther, int YearsDating,
           string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
           string phoneNumber, string email) : base(FirstName, LastName, DateOfBirth, Address, City, State, ZipCode, phoneNumber, email)
        {

            this.Gender = Gender;
            this.NameOfSignificatOther = NameOfSignificatOther;
            this.YearsDating = YearsDating;
        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been Submitted.");
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You Have Been Accepted To Paradise Island.");
        }
        
    }
}
