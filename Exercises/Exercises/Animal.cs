using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    abstract class Animal
    {
        protected string Name {  get; set; }
        protected int Age { get; set; }

        public Animal(string name,int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Wooof");
        }

    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Horse : Animal
    {
        public Horse(string name, int age) : base(name, age) { }

        public override void Speak()
        {
            Console.WriteLine("Neigh!");
        }
    }
}
