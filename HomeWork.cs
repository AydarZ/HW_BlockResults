string[] CreateAndFillNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
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

void PrintTheAnswer(string[] array)
{
    if (array[0] != null)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i]);
            if (array[i + 1] != null) System.Console.Write(", ");
            else return;
        }
    }
    else
    {
        System.Console.WriteLine("В заданном массиве не содержатся элементы с длинной не более трех символов");
    }
}

string[] Array = { "Выведи", "слово", "УРА", "!!!" };
string[] NewArray = CreateAndFillNewArray(Array);
PrintTheAnswer(NewArray);
