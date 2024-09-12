namespace Mindbox.Library.Geometry.Exceptions.Circle;

public class CircleBaseException(double radius) : ShapeBaseException([radius]) // для всех невалидных кругов 
{
    public override string Msg => $"Invalid circle with radius of {radius}";
}