using System;
using static System.Console;

namespace ContactManager
{
    [Serializable]
    public class Contact
    {
        public uint ContactID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateOfBirth DateOfBirth { get; set; }
        public PhoneNumbers PhoneNumbers { get; set; }
        public Email Email { get; set; }
        public string City { get; set; }
        public Contact() { }

        ~Contact() { }

        public Contact(
            uint _contactID,
            string _surname,
            string _name,
            string _patronymic,
            DateOfBirth dateOfBirth,
            PhoneNumbers phoneNumbers,
            Email email,
            string _city)
        {
            ContactID = _contactID;
            Surname = _surname;
            Name = _name;
            Patronymic = _patronymic;
            City = _city;
        }

        void info()
        {
            WriteLine($"id: {ContactID}");
            WriteLine($"contact: {Surname} {Name} {Patronymic}");
            WriteLine($"birth: {DateOfBirth.YearBirth}.{DateOfBirth.MonthBirth}.{DateOfBirth.DayBirth}\tage: AgeNow");
            WriteLine($"M_phone: {PhoneNumbers.Mobile}");
            WriteLine($"W_phone: {PhoneNumbers.Work}");
            WriteLine($"W_email: {Email.Work}");
            WriteLine($"city: {City}");
        }
    }

}