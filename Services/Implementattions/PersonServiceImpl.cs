﻿using System;
using System.Collections.Generic;
using System.Threading;
using RestWithASPNET.Controllers.Model;

namespace RestWithASPNET.Services.Implementattions
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public PersonServiceImpl()
        {
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }


        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Kelvin",
                LastName = "Ott",
                Address = "Pomerode - SC",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person Lastname" + i ,
                Address = "Some Address" + i,
                Gender = "Male" + i
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
