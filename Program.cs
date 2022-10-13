Console.WriteLine("Введите массив строк:");
string[] arrString = Console.ReadLine().Split(" ");
Console.WriteLine("------------------------------------------");
Console.WriteLine("Массив из элементов длиной меньше или равных 3:");
Array.ForEach(arrIs3OrLess(arrString), Console.WriteLine);

string[] arrIs3OrLess(string[] arrString)
{
    string tempString = "";

    foreach (string tmp in arrString)
    {
        if (tmp.Length <= 3)
        {
            tempString += " " + tmp;
        }
    }

    return tempString.Trim().Split(" ");
}