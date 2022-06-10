// See https://aka.ms/new-console-template for more information

// In class-based programming, the factory method pattern is a creational pattern that
// uses factory methods to deal with the problem of creating objects without having to specify
// the exact class of the object that will be created. This is done by creating objects by calling
// a factory method—either specified in an interface and implemented by child classes,
// or implemented in a base class and optionally overridden by derived classes—rather
// than by calling a constructor.
// https://en.wikipedia.org/wiki/Factory_method_pattern


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is an awesome program to learn about creational patterns \n"
        + "which one shall be executed? \n1.The abstract factory \n2.the factory \n3.Builder\n"
        + "4.Prototype \n5.Singleton\nInsert corresponding number and press Enter");
        String selection = Console.ReadLine();
        if (selection == "2")
        {
            Console.WriteLine("please enter \n'triangle', \n'rectangle', \nor 'circle'");
            selection = Console.ReadLine();
            ShapeFactory2D shape = new ShapeFactory2D();
            var chosenShape = shape.get2DShape(selection);
            if (chosenShape != null)
            {
                chosenShape.draw();
            }
        }
        else System.Console.WriteLine("nothing here yet");
    }
}

