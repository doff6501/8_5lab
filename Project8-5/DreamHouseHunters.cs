using System;
using System.Collections.Generic;
using System.Text;

namespace Project8_5
{

    class DreamHouseHunters : Tvshows
    {
        public string JobTitle;
        public int CurrentAnnualIncome;
        public int WhentoBuyHouse;
        public int NumberOfBedrooms;
        public int NumberOfBathrooms;


        public DreamHouseHunters(string JobTitle,int CurrentAnnualIncome, int WhentoBuyHouse, int NumberOfBedrooms, int NumberOfBathrooms,
               string FirstName, string LastName, string DateOfBirth, string Address, string City, string State, int ZipCode,
               string phoneNumber, string email) : base(FirstName, LastName, DateOfBirth, Address, City, State, ZipCode, phoneNumber, email)

        {

            this.JobTitle = JobTitle;
            this.CurrentAnnualIncome = CurrentAnnualIncome;
            this.WhentoBuyHouse = WhentoBuyHouse;
            this.NumberOfBedrooms = NumberOfBedrooms;
            this.NumberOfBathrooms = NumberOfBathrooms;
        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been Submitted.");
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You Have Been Accepted To Dream House Hunters.");
        }
    }
}
