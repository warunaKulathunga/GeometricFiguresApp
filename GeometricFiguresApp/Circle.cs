public class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public void Move(int deltaX, int deltaY)
    {
        Center.Move(deltaX, deltaY);
    }

    public void Rotate(double angle)
    {
        Center.Rotate(angle);
    }


    public override string ToString()
    {
        return $"Circle(Center: {Center}, Radius: {Radius})";
    }
}
