using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Cat
    {
        //Declare Fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Declare Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Cat()
        {
            //Default Constructor
        }

        public Cat(string name, int age, string furColor)
        {
            //Loaded Constructor
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}
