using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Person
    {
        private string Name { get; set; }
        private DateTime BirthDate { get; set; }
        private Genders Gender { get; set; }

        public Person(string Name, DateTime Birthdate, Genders Gender)
        {
            this.Name = Name;
            this.BirthDate = Birthdate;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"Person {Name} was born on: {BirthDate.ToLongDateString()} and is of {Gender} gender.";
        }
    }
}
