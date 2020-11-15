using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName =>
            $"{LastName}, {FirstName}";
    }
}
