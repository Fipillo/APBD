


Console.WriteLine("Hello, World!");

Console.WriteLine("Commit_1 done");


Console.WriteLine("zamiast modyfikacji wypusije commit, whatever")

public static double CalculateAverage(int[] numbers)
{
    int sum = 0;
    
    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

public static int FindMax(int[] numbers)
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
