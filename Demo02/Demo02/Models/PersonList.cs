using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02.Models
{
    public class PersonList : List<Person>
    {
        public string Heading { get; set; }
        public List<Person> Persons => this;
    }
}
