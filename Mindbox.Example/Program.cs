using Mindbox.Library.Geometry.Shapes;
using Mindbox.Library.Geometry.Strategy;

var context = new Context(new Circle(5)); // чтобы было удобно добавлять новые фигуры решил использовать паттерн Стратегия
var area = context.ExecuteCalculateArea();
Console.WriteLine($"Площадь круга: {area}");

context.Shape = new Triangle(3, 4, 5);
area = context.ExecuteCalculateArea();
Console.WriteLine($"Площадь треугольника: {area}");

if (context.Shape is Triangle triangle && triangle.IsRightAngled())
{
    Console.WriteLine("Треугольник является прямоугольным");
}