using System;
using System.Collections.Generic;
using System.Text;

namespace DochazkovySystem
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PersonalNumber { get; set; }
        public string ChipId { get; set; }
        public int Id { get; set; }
        public List<Record> Records { get; set; }

        public Person()
        {
            Records = new List<Record>();
        }
    }
}
