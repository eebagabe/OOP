namespace ObjectOriented.Classes.Constructors;

public class Wall
{
    public int Depth { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Volume { get; set; }

    public Wall(int depth, int height, int width)
    {
        Depth = depth;
        Height = height;
        Width = width;
        Volume = depth * height * width;
    }
}
