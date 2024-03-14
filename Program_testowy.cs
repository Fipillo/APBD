


Console.WriteLine("Hello, World!");

Console.WriteLine("Commit_1 done");


Console.WriteLine("zamiast modyfikacji wypusije commit, whatever")

public static double CalculateAverage(int[] numbers)
{
    int s = 0;
    
    //comment LOL
    
    foreach (int n in numbers)
    {
        s += n;
    }

    return s / numbers.Length;
}


public static double FindMax(int[] numbers)
{
    int max = 0;
    
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

    return max;
}

