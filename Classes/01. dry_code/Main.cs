namespace ObjectOriented.Classes.DryCode;

public record Soldier(int Damage, int AttacksPerSecond);

public static class Exercise
{
    public static int GetSoldierDps(Soldier soldier)
    {
        return soldier.Damage * soldier.AttacksPerSecond;
    }

    public static string FightSoldiers(Soldier soldierOne, Soldier soldierTwo)
    {
        var soldierOneDps = GetSoldierDps(soldierOne);
        var soldierTwoDps = GetSoldierDps(soldierTwo);
        if (soldierOneDps > soldierTwoDps)
        {
            return "soldier 1 wins";
        }
        if (soldierTwoDps > soldierOneDps)
        {
            return "soldier 2 wins";
        }
        return "both soldiers die";
    }
}
