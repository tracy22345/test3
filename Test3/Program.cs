using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Circle circle = new Circle(2);
            Console.WriteLine(circle.Area);

            Console.WriteLine(circle.Add(1, 2));
            Console.WriteLine(circle.Add("abc", "def"));*/

            Family f = new Family();
            f.persons.Add(new Person("Mom"));
            f.persons.Add(new Person("Dad"));
            f.pets.Add(new Dog("DD"));
            f.pets.Add(new Cat("CC"));
            f.Print();
        }
    }

    internal class Circle
    {
        private float _radius;
        private float _area;

        public float Area
        {
            get
            {
                return _area;
            }
        }

        public Circle(float radius)
        {
            _radius = radius;
            _area = _radius * _radius * (float)Math.PI;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }

    class Animal
    {
        public string name;
    }

    class Dog : Animal
    {
        public void Bark()
        {

        }

        public Dog(string name)
        {
            this.name = name;
        }
    }

    class Cat : Animal
    {
        public void Mew()
        {

        }

        public Cat(string name)
        {
            this.name = name;
        }
    }

    class Person : Animal
    {
        public string job;

        public Person(string name)
        {
            this.name = name;
        }
    }

    class Family
    {
        public List<Person> persons = new List<Person>();
        public List<Animal> pets = new List<Animal>();

        public void Print()
        {
            string people = "";
            for (int i = 0; i < persons.Count; i++)
            {
                people += persons[i].name + ", ";
            }
            Console.WriteLine(people);

            string p = "";
            for (int i = 0; i < pets.Count; i++)
            {
                p += pets[i].name + ", ";
            }
            Console.WriteLine(p);
        }
    }
}