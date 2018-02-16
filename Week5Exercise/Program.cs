using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[]
            {
                new Dog(),
                new Cat()
            };
            foreach (var item in animal)
            {
                item.Move();
                item.Speak();
                item.ToString();
            }

            Animal dog = new Dog();
            Animal cat = new Cat(); 
            dog.Move();
            dog.Speak();
            dog.ToString();

            cat.Move();
            cat.Speak();
            cat.ToString();

            Console.ReadLine();
        }
    }
}
