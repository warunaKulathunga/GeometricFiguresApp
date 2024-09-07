public class Line
{
    public Point Start { get; set; }
    public Point End { get; set; }

   
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    
    public void Move(int deltaX, int deltaY)
    {
        Start.Move(deltaX, deltaY);
        End.Move(deltaX, deltaY);
    }

    public void Rotate(double angle)
    {
        Start.Rotate(angle);
        End.Rotate(angle);
    }


    public override string ToString()
    {
        return $"Line(Start: {Start}, End: {End})";
    }
}