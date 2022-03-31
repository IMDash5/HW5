void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(-20, 20);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count - 1; pos++)
    {
        Console.Write($"{col[pos]}, ");
    }
    for(int pos = count - 1; pos < count; pos++)
    {
        Console.Write($"{col[pos]} ");
    }
}

int FindSum(int[] arg)
{
    int sum = 0;
    int length = arg.Length;
    for (int i = 0; i < length; i = i + 2)
    {
        sum = sum + arg[i];
    }
    return sum;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int result = FindSum(array);
Console.WriteLine(result);
