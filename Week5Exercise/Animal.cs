using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise
{
    public abstract class Animal
    {
        private double weight;
        private string name;

        public abstract void Speak();
        public abstract void Move();
        public abstract void ToString();

    }
    public class Dog : Animal
    {
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
        public override void Move()
        {
            Console.WriteLine("A dog is fast");
        }
        public override void Speak()
        {
            Console.WriteLine("A dog barks");
        }
        public override void ToString()
        {
            Console.WriteLine("Hello World i'm a dog");
        }
    }
    public class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("A Cat is faster than a dog");
        }
        public override void Speak()
        {
            Console.WriteLine("A Cat meows");
        }
        public override void ToString()
        {
            Console.WriteLine("Hello World i'm a cat");
        }
    }
}
