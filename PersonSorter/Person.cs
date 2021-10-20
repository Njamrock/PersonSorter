namespace PersonSorter
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Birthdate { get; set; }
        public string CountryOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public Person(string name, string lastName, string gender, string birthdate, string countryOfBirth, string placeOfBirth)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.CountryOfBirth = countryOfBirth;
            this.PlaceOfBirth = placeOfBirth;
        }
    }
}
