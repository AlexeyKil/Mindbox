using Mindbox.Library.Geometry.Exceptions.Circle;
using Mindbox.Library.Geometry.Exceptions.Triangle;
using Mindbox.Library.Geometry.Shapes;

namespace Mindbox.Library.Tests;

public class GeometryTests
{
    #region ReturnsCorrectArea 
    
    [Test]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        var area = circle.CalculateArea();
        Assert.That(area, Is.EqualTo(Math.PI * 25).Within(0.0001));
    }

    [Test]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        Assert.That(area, Is.EqualTo(6).Within(0.0001));
    } 

    #endregion
    
    #region IsRightAngled
    
    [Test]
    public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRightAngled(), Is.True);
    }

    [Test]
    public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.That(triangle.IsRightAngled(), Is.False);
    }
    
    #endregion

    #region Throws
    
    [Test]
    public void Triangle_WithZeroOrNegativeSides_ThrowsTriangleSizeZeroException()
    {
        Assert.Throws<TriangleSizeZeroException>(() => new Triangle(0, 1, 2));
        Assert.Throws<TriangleSizeZeroException>(() => new Triangle(-1, 1, 2));
        Assert.Throws<TriangleSizeZeroException>(() => new Triangle(1, -1, 2));
        Assert.Throws<TriangleSizeZeroException>(() => new Triangle(1, 2, 0));
    }

    [Test]
    public void Triangle_WithInvalidSides_ThrowsNotTriangleException()
    {
        Assert.Throws<NotTriangleException>(() => new Triangle(1, 2, 3));
        Assert.Throws<NotTriangleException>(() => new Triangle(1, 10, 12));
        Assert.Throws<NotTriangleException>(() => new Triangle(5, 1, 1));
    } 

    [Test]
    public void Circle_WithZeroOrNegativeRadius_ThrowsCircleRadiusZeroException()
    {
        Assert.Throws<CircleRadiusZeroException>(() => new Circle(0));
        Assert.Throws<CircleRadiusZeroException>(() => new Circle(-5));
    }
    
    #endregion
}