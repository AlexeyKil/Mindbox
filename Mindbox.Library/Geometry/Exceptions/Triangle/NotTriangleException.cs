namespace Mindbox.Library.Geometry.Exceptions.Triangle;

public class NotTriangleException(double sideA, double sideB, double sideC) : TriangleBaseException(sideA, sideB, sideC)
{
    public override string Msg => "Provided sizes do not form triangle"; 
}