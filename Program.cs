var exercises = new Dictionary<string, Action>
{
    ["multiple-objects"] = ObjectOriented.Classes.MultipleObjects.Exercise.Run,
    ["class-variables"] = ObjectOriented.Classes.ClassVariablesVsInstanceVariables.Exercise.Run,
};

if (args.Length == 0 || !exercises.TryGetValue(args[0], out var run))
{
    Console.WriteLine($"Usage: dotnet run -- <{string.Join("|", exercises.Keys)}>");
    return;
}

run();
