//string[] array = { "hello", "2", "world", ":-)" };

//string[] array = { "Russia", "Denmark", "Kazan" };
string InputText () {
    Console.WriteLine("Введите через запятую каждый элемент массива:");
    string arrStr = Console.ReadLine();
    return arrStr;
}
string s = InputText();



string[] FillArrayWithString(string str) {
    string[] newArr = str.Split(',');
    return newArr; 
}



string[] NewArray(string[]array)
{
    string s = "";
    string sSub = "";

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"] -> ");
        }
        if (array[i].Length <= 3)
        {
            s = s + array[i] + ",";
        }
    }

    if (s.Length > 1 && s[s.Length - 1] == ',')
    {
        sSub = s.Substring(0, s.Length - 1);
    }
    else
        sSub = s;

    string[] sArray = sSub.Split(',');
    Console.Write("[");

    for (int i = 0; i < sArray.Length; i++)
    {
        if (i == sArray.Length - 1)
        {
            Console.Write($"\"{sArray[i]}\"");
        }
        else
        {
            Console.Write($"\"{sArray[i]}\", ");
        }
    }
    Console.Write("]");
    return sArray;
}

InputText();
string[] fillArr = FillArrayWithString(s);
NewArray(fillArr);