public class ShapeFactory2D
{
    public IShape2D get2DShape(string shape)
    {

        shape = shape.ToLower();

        if (shape == "circle")
        {
            return new Circle();
        }
        if (shape == "triangle")
        {
            return new Triangle();
        }
        if (shape == "rectangle")
        {
            return new Rectangle();
        }

        return null;
    }
}