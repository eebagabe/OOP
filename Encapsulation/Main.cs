namespace ObjectOriented.Encapsulation;

public class Wizard
{
    private int _stamina;
    private int _intelligence;

    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }

    public Wizard(string name, int stamina, int intelligence)
    {
        _stamina = stamina;
        _intelligence = intelligence;

        Name = name;

        Health = _stamina * 100;
        Mana = _intelligence * 10;
    }
}
