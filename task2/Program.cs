int[] myArray = new int[5]; // Создаем и заполняем массив случайными трехзначными числами
Random rand = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(-10, 10);
}

int SumOddPosition(int[] arr)
{
    int sumOdd = 0;
    for (int i = 1; i < arr.Length; i+=2) sumOdd+=arr[i];
    return sumOdd;
}

Console.Write(string.Join(", ", myArray));
Console.WriteLine(" ");
Console.WriteLine(SumOddPosition(myArray));