public class Aggregation
{
    private List<object> figures = new List<object>();

    
    public void AddFigure(object figure)
    {
        figures.Add(figure);
    }

    public void Move(int deltaX, int deltaY)
    {
        foreach (var figure in figures)
        {
            if (figure is Point point)
                point.Move(deltaX, deltaY);
            else if (figure is Line line)
                line.Move(deltaX, deltaY);
            else if (figure is Circle circle)
                circle.Move(deltaX, deltaY);
        }
    }
 
    public void Rotate(double angle)
    {
        foreach (var figure in figures)
        {
            if (figure is Point point)
                point.Rotate(angle);
            else if (figure is Line line)
                line.Rotate(angle);
            else if (figure is Circle circle)
                circle.Rotate(angle);
        }
    }

    public override string ToString()
    {
        return string.Join(", ", figures.Select(f => f.ToString()));
    }
}