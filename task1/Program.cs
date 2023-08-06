int[] myArray = new int[5]; // Создаем и заполняем массив случайными трехзначными числами
Random rand = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(100, 1000);
}

int SumEven(int[] arr) // метод который считает сколько четных чисел в массиве
{
    int numEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2) == 0)
        {
            numEven++;
        }
    }
    return numEven;
}

Console.Write(string.Join(", ", myArray));
Console.WriteLine(" ");
Console.WriteLine(SumEven(myArray));