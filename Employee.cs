using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Employee : Person 
    {
        private decimal Salary { get; set; }
        private Professions Profession { get; set; }
        private Room RoomNumber { get; set; }
        public Employee(string name, DateTime birthDate, Genders gender, 
            decimal salary, Professions profession, Room roomNumber) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"Person {Name} born on: {BirthDate.ToLongDateString()}, gender: {Gender}, " +
                $"salary: {Salary:C}, profession: {Profession}, room: {RoomNumber.Number}.";
        }
    }
}
