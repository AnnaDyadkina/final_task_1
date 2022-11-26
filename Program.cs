Console.WriteLine("Введите длину массива");
string inputLength = Console.ReadLine();

int temp;

if (int.TryParse(inputLength, out temp))
{
    int valueLength = int.Parse(inputLength);
    if (valueLength > 0 )
    {
        string[] valueArr = new string[valueLength];
        string valueItem = String.Empty;
        for (int count = 0; count < valueLength; count++)
        {
            valueItem = Prompt("Введите элемент массива");
            valueArr[count] = valueItem;
        }

        string[] resultArr = Array.FindAll(valueArr, item => item.Length <= 3);
        foreach (var item in resultArr) Console.Write($"{item} ");
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}
else
{
    Console.WriteLine("Введите число");
}



string Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  string value = Console.ReadLine();
  return value;
}




