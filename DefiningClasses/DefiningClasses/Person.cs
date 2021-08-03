using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
        {
            this.Age = age;
            Name = "No name";
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Print()
        {
            return this.Name + " " + this.Age;
        }

    }

    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            int resultIndex = 0;
            for (int i = 0; i < People.Count - 1; i++)
            {
                if (People[i].Age < People[i + 1].Age)
                {
                    resultIndex = i + 1;
                }
            }
            return People[resultIndex];
        }
    }
}
