using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //have  a class be able to inherit charecteristic of another
            //can have a superclass and other specials

            Chef chef = new Chef(); // the chef object
            chef.MackeChicken();


            ItalianChef chef1 = new ItalianChef();
            chef1.MackeChicken();//Italian chef his inheritance! Chef is superclass, Italian Chef is subclass
            chef1.MakePasta();// calling his own method, Chef cant call on Make Pasta
            chef1.MakeSpecialDish();

            //freeze
            Console.ReadLine();
        }
    }
}
