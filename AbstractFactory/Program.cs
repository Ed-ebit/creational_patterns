//The abstract factory pattern provides a way to encapsulate a group of individual factories that
//have a common theme without specifying their concrete classes.[1] 
//https://en.wikipedia.org/wiki/Abstract_factory_pattern



using AbstractFactory.Classes;
using AbstractFactory.Interfaces;
class Program
{


    public static void addToMaterialList(IHouseElements element, List<IHouseElements> materialList)
    {
        element.Description();
        materialList.Add(element);
    }

    public static void Main()
    {
        Console.WriteLine("Hello! Abstract Factory for Creation of Varying Sets of product-types here!");
        Console.WriteLine("Holz oder Metallhaus?");
        string selection = "";
        IAbstractFactory generator = null;
        List<IHouseElements> materialList = new List<IHouseElements>();

        do
        {
            selection = Console.ReadLine();
            selection = selection.ToLower();
            if (selection == "holz")
            {
                Console.WriteLine("Holzhaus!");
                generator = new WoodenFactory();
            }
            if (selection == "metall")
            {
                Console.WriteLine("Metallhaus!");
                generator = new MetallFactory();
            }
            else Console.WriteLine("ungültige Eingabe");
        } while (selection != "holz" && selection != "metall");

        while (true)
        {
            Console.WriteLine("press: 1 for a Roof, 2 for a wall, 3 for a Door, 4 for exit");
            selection = Console.ReadLine();
            selection = selection.ToLower();

            if (selection == "1")
            {
                IHouseElements element = generator.ProduceRoof();
                addToMaterialList(element, materialList);

            }
            if (selection == "2")
            {
                IHouseElements element = generator.ProduceWall();
                addToMaterialList(element, materialList);
            }
            if (selection == "3")
            {
                IHouseElements element = generator.ProduceDoor();
                addToMaterialList(element, materialList);
            }
            if (selection == "4")
            {
                Console.WriteLine("built elements: ");
                foreach (var material in materialList)
                {
                    Console.WriteLine(material);
                }
                return;
            }
        }
    }
}




