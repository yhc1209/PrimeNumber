try
{
    int[] Primes = getPrimeII(Int32.Parse(args[0]), (args.Length > 1 && args[1].ToLower() == "show"));
    Console.WriteLine("result: " + string.Join(", ", Primes));
}
catch (Exception e)
{
    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
}

int[] getPrimeI(int x)
{
    List<int> arr = new List<int>();
    if (x > 0) arr.Add(1);

    for (int i = 2; i <= x;  i++)
    {
        for (int j = 2; j <= i/2; j++)
        {
            if (i%j == 0)
            {
                arr.Add(j);
                break;
            }
        }
    }

    List<int> prime = new List<int>();
    for (int p = 0; p <= x; p++)
    {
        if (arr.Contains(p))
            continue;
        else
            prime.Add(p);
    }

    return prime.ToArray();
}

int[] getPrimeII(int x, bool bShow)
{
    if (x < 2)
        return new int[0];

    List<int> primes = new List<int>();
    for (int i = 2; i <= x; i++)
    {
        if (bShow) Console.WriteLine($"#{i}:");
        string component = "  ";
        int ii =  i;
        for (int j = 2; j < ii; j++)
        {
            if (i%j == 0)
            {
                ii = i/j;
                component += $"{j}x{ii},";
            }
        }
        if (component.Length == 2)
        {
            primes.Add(i);
            if (bShow) Console.WriteLine("  is prime number.");
        }
        else
            if (bShow) Console.WriteLine(component.TrimEnd(','));
    }

    return primes.ToArray();
}