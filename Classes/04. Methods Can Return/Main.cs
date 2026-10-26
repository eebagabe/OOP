namespace ObjectOriented.Classes.MethodsCanReturn;

public class Wall
{
    public int Armor { get; set; } = 10;
    public int Height { get; set; } = 5;

    public int GetCost()
    {
        var cost = Armor * Height;
        return cost;
    }

    // don't touch below this line

    public void Fortify()
    {
        Armor *= 2;
    }
}
