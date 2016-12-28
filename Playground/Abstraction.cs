using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Abstraction
    {
    }

    public class Test
    {
        public Test()
        {
            var dog = new Dog();
            var cat = new Cat();

            dog.Legs = 4;
            dog.Eyes = 2;
            dog.isMansBestFriend();

            cat.Legs = 4;
            cat.Eyes = 2;
            cat.isMansBestFriend();
        }
    }
    public abstract class Animal
    {
        public int Legs { get; set; }

        public int Eyes { get; set; }

        public bool Loyal { get; set; }

        public bool isMansBestFriend()
        {
            return Loyal;
        }

        //public abstract bool follow();
    }

    public class Dog : Animal
    {
        public bool isDog() { return true; }
        
        //public bool follow() { return true; }
    }

    public class Cat : Animal
    {
        //public bool follow() { return false; }
    }
}
