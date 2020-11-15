using Demo02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02.ViewModels
{
    public class GroupedListViewModel :BaseViewModel
    {
        private List<PersonList> _listOfPeople;

        public List<PersonList> ListOfPeople
        {
            get => _listOfPeople; 
            set => SetProperty(ref _listOfPeople, value);
        }

        public GroupedListViewModel()
        {
            var slist = new PersonList
            {
                new Person {FirstName = "Sally", LastName = "Sampson" },
                new Person {FirstName = "Taylor", LastName = "Swift" },
                new Person {FirstName = "John", LastName = "Smith" }
            };
            slist.Heading = "Letter-S";

            var dlist = new PersonList
            {
                new Person {FirstName = "Jane", LastName = "Doe" },
                new Person {FirstName = "Dick", LastName = "Donald" },
                new Person {FirstName = "Anna", LastName = "Dog" }
            };
            dlist.Heading = "Letter-D";

            var jlist = new PersonList
            {
                new Person {FirstName = "Billy", LastName = "Joel" }
            };
            jlist.Heading = "Letter-J";

            var list = new List<PersonList>
            {
                slist, dlist, jlist
            };

            ListOfPeople = list;
        }
    }
}
