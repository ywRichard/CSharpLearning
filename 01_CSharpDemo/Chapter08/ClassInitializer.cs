using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class ClassInitializer
    {
        private Person _tom;
        public Person Tom
        {
            get => _tom;
            set { }
        }

        public ClassInitializer()
        {
            _tom = new Person("Tom")
            {
                Age = 9,
                Home = { Country = "UK", Town = "Reading" },//如果属性的类型时类，那么在类初始化器中初始化该类型时可以不用new.
                Friends =
                {
                    new Person{Name="Albert"},
                    new Person("Max"),
                    new Person{Name="Zak",Age=7},
                    new Person("Ben"),
                    new Person("Alice")
                    {
                        Age=9,
                        Home={Town= "Twyford",Country = "UK"}
                    }
                }
            };
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        List<Person> _friends = new List<Person>();

        public List<Person> Friends
        {
            get => _friends;
            set => _friends = value;
        }

        Location _home = new Location();
        public Location Home => _home;

        public Person() { }
        public Person(string name)
        {
            Name = name;
        }

        //public class Location
        //{
        //    public string Country { get; set; }
        //    public string Town { get; set; }
        //}

        public override string ToString()
        {
            return $"Name:{Name}; Age:{Age}; Country:{Home.Country}; Town:{Home.Town}";
        }
    }

    public class Location
    {
        public string Country { get; set; }
        public string Town { get; set; }
    }

}
