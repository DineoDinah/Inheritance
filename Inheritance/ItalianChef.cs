using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ItalianChef: Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish() //use keyword override
        {
            Console.WriteLine("The chef makes Italianspecials");
        }
    }

}

