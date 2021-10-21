using System;

namespace PersonSorter
{
    public class Person
    {
        public int SequenceNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string CountryOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public Person(string name, string lastName, string gender, string birthdate, string countryOfBirth, string placeOfBirth)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Gender = gender;
            this.Birthdate = this.BirthdateParser(birthdate);
            this.CountryOfBirth = countryOfBirth;
            this.PlaceOfBirth = placeOfBirth;
        }

        private DateTime BirthdateParser(string birthdate)
        {
            var arrayOfBirthdateStrings = birthdate.Split('.');
            return new DateTime(Convert.ToInt32(arrayOfBirthdateStrings[2]), Convert.ToInt32(arrayOfBirthdateStrings[1]), Convert.ToInt32(arrayOfBirthdateStrings[0]));
        }
    }
}
