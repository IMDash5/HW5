void FillArray(double[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(-20, 20);
        i++;
    }
}

void PrintArray(double[] col)
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

double FindDif(double[] arg)
{
    double max = arg[0];
    double min = arg[0];
    double dif = 0;
    int length = arg.Length;
    for (int i = 1; i < length; i++ )
    {
        if (arg[i] > max)
        {
            max = arg[i];
        }
        else 
        {
            if (arg[i] < min)
            {
                min = arg[i];
            }
        }
        dif = max - min;
    }
    return dif;
}

double[] array = new double[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

double result = FindDif(array);
Console.WriteLine(result);