using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class WoodenWall: IHouseElements
    {
        public void Description()
        {
            Console.WriteLine("Ich bin eine Holzwand!");
        }
    }
}
