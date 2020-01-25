using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Person(
            int id,
            string name,
            string lastName,
            string phone)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Phone = phone;
        }
    }
}
