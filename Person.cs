using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Person
    {
        protected string Name { get; set; }
        protected DateTime BirthDate { get; set; }
        protected Genders Gender { get; set; }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Person {Name} was born on: {BirthDate.ToLongDateString()} and is of {Gender} gender.";
        }
    }
}
