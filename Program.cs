using YieldDemo;

Console.WriteLine(value: "Start of the App");

var people = DataAccessHelpers.GetPeople().Take(count: 2);

foreach (var p in people)
{
    Console.WriteLine(value: $"Read {p.FirstName} {p.LastName}");
}
Console.WriteLine(value: "End of the App");