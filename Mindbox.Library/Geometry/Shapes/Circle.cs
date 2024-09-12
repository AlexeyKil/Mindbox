using Mindbox.Library.Geometry.Exceptions.Circle;

namespace Mindbox.Library.Geometry.Shapes;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new CircleRadiusZeroException(radius);
        }
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}