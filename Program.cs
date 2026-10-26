var exercises = new Dictionary<string, Action>
{
};

if (args.Length == 0 || !exercises.TryGetValue(args[0], out var run))
{
    Console.WriteLine($"Usage: dotnet run -- <{string.Join("|", exercises.Keys)}>");
    return;
}

run();
