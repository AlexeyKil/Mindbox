namespace Mindbox.Library.Geometry.Exceptions.Triangle;

public class TriangleBaseException(double sideA, double sideB, double sideC) : ShapeBaseException([sideA, sideB, sideC])
{
    public override string Msg => $"Invalid triangle with sizes of {sideA}, {sideB}, {sideC}";
}