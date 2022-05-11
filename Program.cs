Console.WriteLine("Введите 5 слов или чисел:");
string one = Console.ReadLine();
string two = Console.ReadLine();
string three = Console.ReadLine();
string four = Console.ReadLine();
string five = Console.ReadLine();

string[] startArray = new string[5] {one, two, three, four, five};
string[] finishArray = new string[startArray.Length];
int finArrayLen = 0;

void CheckArray(string[] startArray, string[] finishArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
    if(startArray[i].Length <= 3)
        {
        finishArray[count] = startArray[i];
        count++;
        finArrayLen++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < finArrayLen; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
Console.WriteLine();
Console.WriteLine("Введённые данные с количеством 3 и менее символов:");
CheckArray(startArray, finishArray);
PrintArray(finishArray);