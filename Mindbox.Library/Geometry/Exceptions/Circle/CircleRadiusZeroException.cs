namespace Mindbox.Library.Geometry.Exceptions.Circle;

public class CircleRadiusZeroException(double radius) : CircleBaseException(radius)
{
    public override string Msg => "Radius must not be zero";
}