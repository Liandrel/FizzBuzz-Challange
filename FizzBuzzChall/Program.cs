

//FizzBuzz(0, 120);


List<DivisableRuleInfo> rules = new();
rules.Add(new DivisableRuleInfo("FizzBuzzJazz", new[] { 3, 5, 7 }));
rules.Add(new DivisableRuleInfo("FizzBuzz", new[] { 3, 5 }));
rules.Add(new DivisableRuleInfo("FizzJazz", new[] { 3, 7 }));
rules.Add(new DivisableRuleInfo("BuzzJazz", new[] { 5, 7 }));
rules.Add(new DivisableRuleInfo("Fizz", new[] { 3 }));
rules.Add(new DivisableRuleInfo("Buzz", new[] { 5 }));
rules.Add(new DivisableRuleInfo("Jazz", new[] { 7 }));

var results = FizzBuzzRefactor(rules, 0, 120);

foreach (var result in results)
{
    Console.WriteLine(result);
}



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

bool NumIsDivisableBy(int num, int[] values)
{
    bool output = true;
    for (int i = 0; i < values.Length; i++)
    {
        if (num % values[i] != 0)
        {
            output = false;
            break;
        }
    }
    return output;
}

List<string> FizzBuzzRefactor(List<DivisableRuleInfo> rules, int lowerBound, int upperBound)
{
    List<string> output = new();
    for (int i = lowerBound; i < upperBound; i++)
    {
        bool isFound = false;

        if (i == 0)
        {
            output.Add("0");
            continue;
        }

        foreach (var rule in rules)
        {
            if (NumIsDivisableBy(i, rule.MustBeDivisableBySet))
            {
                output.Add($"{rule.WordToPrint} ({i})");
                isFound = true;
            }
        }

        if (isFound == false)
        {
            output.Add(i.ToString());
        }

    }
    return output;
}
