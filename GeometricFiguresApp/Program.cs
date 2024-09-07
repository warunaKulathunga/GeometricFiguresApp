class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(3, 4);
        Point p3 = new Point(2, 3);
        Point p4 = new Point(2, 3);
        Point p5 = new Point(2, 3);
        Point p6 = new Point(5, 7);

        Line line = new Line(p5, p6);

        Circle circle = new Circle(new Point(5, 5), 5);

        Aggregation aggregation = new Aggregation();
        //aggregation.AddFigure(p1);
        aggregation.AddFigure(p3);
        aggregation.AddFigure(line);
        aggregation.AddFigure(circle);

        Console.WriteLine("Before Move:");
        Console.WriteLine(aggregation);

        aggregation.Move(1, 4);
        Console.WriteLine("After Move:");
        Console.WriteLine(aggregation);

        //aggregation.Rotate(45);
        aggregation.Rotate(90);
        Console.WriteLine("After Rotate:");
        Console.WriteLine(aggregation);
    }
}