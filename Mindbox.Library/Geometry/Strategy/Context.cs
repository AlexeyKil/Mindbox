using Mindbox.Library.Geometry.Shapes;

namespace Mindbox.Library.Geometry.Strategy;

public class Context(IShape shape)
{
    public IShape Shape { get; set; } = shape;

    public double ExecuteCalculateArea()
    {
        return Shape.CalculateArea();
    }
}