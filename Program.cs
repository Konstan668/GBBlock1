string[] GetCutArray(string[] array)
{
    int thirdsCharItems = 0;
    int newArraySize = 0;
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArraySize++;
            Array.Resize(ref newArray, newArraySize);
            newArray[thirdsCharItems] = array[i];
            thirdsCharItems++;
        }
    }
    return newArray;
}


void ShowArray(object[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] testArray = { "Hello", "2", "World", ":-)" };
ShowArray(GetCutArray(testArray));

