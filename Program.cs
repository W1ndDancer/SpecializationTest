string[] CreateArray(int size)
{
    return new string[size];
}
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i} element --> ");
        array[i] = Console.ReadLine();
    }
}
string PrintArray(string[] array)
{
    string result = string.Empty;
    int size = array.Length;
    result = "[";
    for (int i = 0; i < size; i++) result += $" {array[i]};";
    result += "]";
    return result;
}
string[] MakeArrWithLenght3orMin(string[] array)
{
    int size = 0;

    for (int k = 0; k < array.Length; k++) if (array[k].Length <= 3) size++;

    string[] newArray = new string[size];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Write("Input size of array --> ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayForTest = CreateArray(size);
FillArray(arrayForTest);
Console.WriteLine();
Console.WriteLine("Ur array is:");
Console.WriteLine(PrintArray(arrayForTest));

string[] array3orMin = MakeArrWithLenght3orMin(arrayForTest);
Console.WriteLine();
Console.WriteLine("Result is:");
Console.Write(PrintArray(array3orMin));