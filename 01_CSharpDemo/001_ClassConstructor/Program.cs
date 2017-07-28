using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            GraduateStudent gs = new GraduateStudent();

            Console.WriteLine(gs.ToString());
        }
    }

    class Person
    {
        protected string Name { get; set; }
        protected Gender Gender { get; set; }
        protected int Age { get; set; }

        public Person()
        {
            Name = "没有名字";
            Gender = Gender.unkown;
            Age = 0;
        }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }

    class Student : Person
    {
        public int ID { get; set; }
        public int Grade { get; set; }

        public Student()
        {
            ID = 0;
            Grade = 0;
        }

        public Student(int id, int grade, string name, int age, Gender gender) : base(name, age, gender)
        {
            ID = id;
            Grade = grade;
        }
    }

    class GraduateStudent : Student
    {
        public int Score { get; set; }
        public bool GetDiploma { get; set; }

        public GraduateStudent() : this(10, false)
        {

        }

        public GraduateStudent(int scroe, bool getDiploma) : base()
        {
            Score = Score;
            GetDiploma = getDiploma;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}",Name,Age,Gender.ToString());
        }
    }

    internal enum Gender
    {
        male,
        female,
        unkown
    }
}
