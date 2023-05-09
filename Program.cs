using System.Linq;

Console.Write("Input data separated by ', ':");
string? str = Console.ReadLine();
string[] array = str.Split(", ")
                     .ToArray();


void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


string[] FindShortString(string[] array)
{
    int index = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            index++;
            newArray[index] = array[i];
        }
    }
    return newArray;
}

ShowArray(array);

string[] myArray = FindShortString(array);
ShowArray(myArray);
