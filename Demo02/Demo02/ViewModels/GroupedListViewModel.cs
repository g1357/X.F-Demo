using Demo02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02.ViewModels
{
    public class GroupedListViewModel : BaseViewModel
    {
        private List<PersonList> _listOfPeople;

        public List<PersonList> ListOfPeople
        {
            get => _listOfPeople;
            set => SetProperty(ref _listOfPeople, value);
        }

        public GroupedListViewModel()
        {
            var list = new List<PersonList>
            {
                new PersonList
                {
                    Heading = "Letter-S",
                    Persons = {
                        new Person {FirstName = "Sally", LastName = "Sampson" },
                        new Person {FirstName = "Taylor", LastName = "Swift" },
                        new Person {FirstName = "John", LastName = "Smith" }
                    }
                },
                new PersonList
                {
                    Heading = "Letter-D",
                    Persons = {
                        new Person {FirstName = "Jane", LastName = "Doe" },
                        new Person {FirstName = "Dick", LastName = "Donald" },
                        new Person {FirstName = "Anna", LastName = "Dog" }
                    }
                },
                new PersonList
                {
                    Heading = "Letter-J",
                    Persons = {
                        new Person {FirstName = "Billy", LastName = "Joel" }
                    }
                }
            };

            ListOfPeople = list;
        }
    }
}
