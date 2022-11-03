{
    int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
    Console.Write("Ilk ve sonuncunu swap eliyende: ");
    foreach (var i in item)
    {
        Console.Write(i.ToString() + " ");
    }
}
static int[] test(int[] numbers)
{
    int first = numbers[0];
    numbers[0] = numbers[numbers.Length - 1];
    numbers[numbers.Length - 1] = first;

    return numbers;
}