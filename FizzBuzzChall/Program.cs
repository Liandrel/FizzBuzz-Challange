
//FizzBuzz(0, 120);

void FizzBuzz(int lowerBound, int upperBound)
{
    Dictionary<int, string> rules = new();
    rules.Add(3, "Fizz");
    rules.Add(5, "Buzz");
    rules.Add(7, "Jazz");

    for (int i = lowerBound; i <= upperBound; i++)
    {
        string result = "";

        if (i == 0)
        {
            Console.WriteLine(0);
            continue;
        }

        foreach (var rule in rules)
        {
            if (i % rule.Key == 0)
            {
                result += rule.Value;
            }
        }

        if (result.Length > 0)
        {
            Console.WriteLine($"{result} ({i})");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}