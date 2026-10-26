namespace ObjectOriented.Classes;

public static class Exercise
{
    public static List<int> DestroyWalls(List<int> wallHealth)
    {
        var healthWalls = new List<int>();
        foreach (var wall in wallHealth)
        {
            if (wall > 0)
            {
                healthWalls.Add(wall);
            }
        }
        return healthWalls;
    }
}
