using System;
using System.Collections.Generic;
using System.Text;

namespace DochazkovySystem
{
    public class SqlRepository
    {
        private List<Person> TempPeople()
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person()
            {
                Id = 1,
                ChipId = "123456",
                Firstname = "John",
                Lastname ="Doe",
                PersonalNumber = "0001110000110"
            };
            Person person2 = new Person()
            {
                Id = 2,
                ChipId = "123456",
                Firstname = "Petr",
                Lastname = "Lanik",
                PersonalNumber = "11240000110"
            };
            people.Add(person1);
            people.Add(person2);

            return people;
        }
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            return TempPeople();
        }
    }
}
