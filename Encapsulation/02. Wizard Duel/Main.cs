namespace ObjectOriented.Encapsulation.WizardDuelFireball;

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

    public void CastFireball(Wizard target, int fireballCost, int fireballDamage)
    {
        if (Mana < fireballCost)
        {
            throw new Exception($"{Name} cannot cast fireball");
        }

        Mana -= fireballCost;
        target.GetFireballed(fireballDamage);
    }

    public bool IsAlive()
    {
        if (Health > 0)
        {
            return true;
        }

        return false;
    }

    public void GetFireballed(int fireballDamage)
    {
        fireballDamage -= _stamina;
        Health -= fireballDamage;
    }

    public void DrinkManaPotion(int potionMana)
    {
        potionMana += _intelligence;
        Mana += potionMana;
    }
}
