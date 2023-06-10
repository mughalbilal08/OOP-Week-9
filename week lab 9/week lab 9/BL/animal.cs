using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_lab_9.BL
{
    class animal
    {
        protected string name;
        public animal()
        {

        }
        public animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            return ("Animal Name: " + name);
        }
        public virtual void greets()
        {
            Console.WriteLine(" ");
        }
        public virtual void greet(dog another)
        {
            Console.WriteLine(" ");
        }
    }
    class mammal : animal
    {
        public mammal()
        {

        }

        public mammal(string name)
        {
            this.name = name;
        }
        public override string toString()
        {
            return ("Mammal Name: " + name);
        }
        public override void greet(dog another)
        {
            Console.WriteLine(" ");
        }
    }
    class cat : mammal
    {
        public cat(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return ("Cat Name: " + name);
        }
    }
    class dog : mammal
    {
        public dog()
        {

        }
        public dog(string name) : base(name)
        {

        }
        public override void greets()
        {
            Console.WriteLine("Woof");
        }
        public override void greet(dog another)
        {
            Console.WriteLine("Woooof");
            Console.WriteLine();
        }
        public override string toString()
        {
            return ("Dog Name: " + name);
        }
    }
}
