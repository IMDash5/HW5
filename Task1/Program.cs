void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(100, 999);
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
int FindAmount(int[] arg)
{
    int cnt = 0;
    int length = arg.Length;
    for (int i = 0; i < length; i++ )
    {
        if (arg[i] % 2 == 0)
        {
            cnt++;
        }
    }
    return cnt;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int Amount = FindAmount(array);
Console.WriteLine(Amount);


