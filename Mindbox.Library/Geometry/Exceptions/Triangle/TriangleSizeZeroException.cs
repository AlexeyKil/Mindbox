namespace Mindbox.Library.Geometry.Exceptions.Triangle;

public class TriangleSizeZeroException(double sideA, double sideB, double sideC)
    : TriangleBaseException(sideA, sideB, sideC)
{
    public override string Msg => "One or more of sizes of triangle is zero";
}