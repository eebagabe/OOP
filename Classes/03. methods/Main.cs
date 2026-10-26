namespace ObjectOriented.Classes.Methods;

public class Wall
{
    public int Armor { get; set; } = 10;
    public int Height { get; set; } = 5;

    public void Fortify()
    {
        Armor *= 2;
    }
}
