double[] myArray = new double[5];
Random rand = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] =rand.Next(-100,100) + rand.NextDouble();
}

Console.Write(string.Join(", ", myArray));
Console.WriteLine(" ");
Console.WriteLine($"Сумма максимального {myArray.Max()} и минимального значения {myArray.Min()} = " + (myArray.Max() + myArray.Min()));
