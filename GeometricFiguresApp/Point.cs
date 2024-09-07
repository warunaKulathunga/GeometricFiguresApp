public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int deltaX, int deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public void Rotate(double angle)
    {
        double radians = angle * (Math.PI / 180);

        int newX = (int)(X * Math.Cos(radians) - Y * Math.Sin(radians));
        int newY = (int)(X * Math.Sin(radians) + Y * Math.Cos(radians));
     
        X = newX;
        Y = newY;
    }
    public override string ToString()
    {
        return $"Point({X}, {Y})";
    }
}