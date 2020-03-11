using System;
using System.Collections.Generic;
using System.Text;

namespace Project8_5
{
    class AboveDeck :Tvshows
    {
        public int yearsExperience;
        public string nationality;

        public AboveDeck(int yearsExperience, string nationality,
             string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
             string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.yearsExperience = yearsExperience;
            this.nationality = nationality;
        }

        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been Submitted.");
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've Been Excepted To Above Deck.");
        }

    }
}
