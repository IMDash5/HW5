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

int[] NewArray(int[] arg)
{
    int sum = 0;
    int length = arg.Length;
    int[] SecondArr = new int[length / 2 + length % 2];
    int SecondLength = SecondArr.Length;
    for (int i = 0; i < SecondLength; i++)
    {
        sum = arg[i] + arg[length - (i + 1)];
        SecondArr[i] = sum;
        if (i == SecondLength - 1 && length % 2 == 1)
        {
            SecondArr[i] = arg[i];
            break;
        }
    }
    return SecondArr;
}

int[] array = new int[new Random().Next(1, 10)];

FillArray(array);
PrintArray(array);

Console.WriteLine();

PrintArray(NewArray(array));