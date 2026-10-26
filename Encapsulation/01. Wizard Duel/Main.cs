namespace ObjectOriented.Encapsulation.WizardDuel;

public class Wizard
{
    private int _stamina;
    private int _intelligence;

    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }

    public Wizard(string name, int stamina, int intelligence)
    {
        Name = name;
        _stamina = stamina;
        _intelligence = intelligence;
        Mana = _intelligence * 10;
        Health = _stamina * 100;
    }

    public void GetFireballed(int fireballDamage)
    {
        var damage = fireballDamage - _stamina;
        Health -= damage;
    }

    public void DrinkManaPotion(int potionMana)
    {
        var potionValue = potionMana + _intelligence;
        Mana += potionValue;
    }
}
