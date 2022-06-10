using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
namespace AbstractFactory.Classes
{
    public class WoodenFactory:IAbstractFactory
    {
        public IHouseElements ProduceWall() 
        {
            return new WoodenWall();
        }
        public IHouseElements ProduceDoor()
        {
            return new WoodenDoor();
        }
        public IHouseElements ProduceRoof()
        {
            return new WoodenRoof();
        }
    }
}
