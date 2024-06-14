using YieldDemo;

Console.WriteLine(value: "Start of the App");

//var people = DataAccessHelpers.GetPeople().Take(count: 2);

//foreach (var p in people)
//{
//    Console.WriteLine(value: $"Read {p.FirstName} {p.LastName}");
//}

var primeNumbers = Generators.GetPrimeNumbers().Take(10);
foreach (var prime in primeNumbers)
{
    Console.WriteLine(prime);
}

Console.WriteLine(value: "End of the App");

public class Generators
{
    public static IEnumerable<int> GetPrimeNumbers()
    {
        int counter = 1;
        while(true)
        {
            if(IsPrimeNumber(counter))
            {
                yield return counter; 
            }

            counter++;
        }
    }

    private static bool IsPrimeNumber (int value)
    {
        bool output = true;
        for (int i = 2; i < value / 2; i++)
        {
            if (value % i == 0)
            {
                output = false; 
                break;
            }
        }
        return output;
    }
}