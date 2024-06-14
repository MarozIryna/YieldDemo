using YieldDemo;

internal static class DataAccessHelpers
{
    public static IEnumerable<PersonModel> GetPeople()
    {
        yield return new PersonModel(firstName: "Tim", lastName: "Corey");
        yield return new PersonModel(firstName: "Sue", lastName: "Storm");
        yield return new PersonModel(firstName: "Jane", lastName: "Smith");
    }
}