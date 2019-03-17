using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDI
{
    class Program
    {
        static void Main(string[] args)
        {

            leo.Sound();
            leo.Eat();
            br.Sound();
            br.Eat();
            ele.Sound();
            ele.Eat();
            sq.Sound();

        }
    }


    public interface IAnimal
    {
        void Sound();
        void Eat();

    }


    public class Lion : IAnimal
    {
        public Lion leo = new Lion();


        public void Sound()
        {
            Console.WriteLine("ROAR!");
        }

        public void Eat()
        {
            Console.WriteLine("Eating zebra");
        }

    }

    public class Elephant : IAnimal
    {
        Elephant ele = new Elephant();

        public void Sound()
        {
            Console.WriteLine("Hurrrrreererrrreeeerrrrrrr");
        }

        public void Eat()
        {
            Console.WriteLine("Eating Fruit");
        }

    }
    public class Bear : IAnimal
    {
        Bear br = new Bear();

        public void Sound()
        {
            Console.WriteLine("GRRRROOOOOOWWLLL");
        }

        public void Eat()
        {
            Console.WriteLine("Eating Fish");
        }

    }
    public class Squirrel : IAnimal
    {
        Squirrel sq = new Squirrel();

        public void Sound()
        {
            Console.WriteLine(" Snip Snip");
        }

        public void Eat()
        {
            Console.WriteLine("Eating Nuts");
        }

    }
    // Main class
    public class Animals
    {
        private IAnimal _animal;

        public Animals(IAnimal animal)
        {
            _animal = animal;
        }

        public void Sound()
        {
            _animal.Sound();
        }

        public void Eat()
        {
            _animal.Eat();
        }



    }

}
   
    
