namespace Mindbox.Library.Geometry.Exceptions;

public class ShapeBaseException(IEnumerable<double> sizes) : ArgumentException
{  
    public virtual string Msg => $"Provided sizes do not form a valid. Sizes {string.Join(", ", sizes)}";
}