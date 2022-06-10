using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory.Classes
{
    public class MetallFactory:IAbstractFactory
    {
        public IHouseElements ProduceWall()
        {
            return new MetallWall();
        }
        public IHouseElements ProduceDoor()
        {
            return new MetallDoor();
        }
        public IHouseElements ProduceRoof()
        {
            return new MetallRoof();
        }
    }
}
