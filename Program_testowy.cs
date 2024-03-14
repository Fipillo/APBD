


Console.WriteLine("Hello, World!");

Console.WriteLine("Commit_1 done");


Console.WriteLine("zamiast modyfikacji wypusije commit, whatever")

public static double CA(int[] all_numbers)
{
    int sum_of_numbers = 0;
    
    foreach (int tmp_number in all_numbers)
    {
        sum_of_numbers += tmp_number;
    }

    return sum_of_numbers / all_numbers.Length;
    //WEEEEEEEEEEEEEE
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

