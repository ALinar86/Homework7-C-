int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
} 

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ViewNumber(int x, int y, int[,] array)
{
    int num = 0;
   
    if (x >= array.GetLength(0) || y >= array.GetLength(1)) 
    Console.WriteLine("Такого числа нет.");
    else
    {
       num = array[x, y];
       Console.WriteLine("Значение числа с указанными координатами:" + num);
    }
}

Console.Write("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,1,9);
Show2dArray(myArray);
Console.Write("Enter the row index: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column index: ");
int y = Convert.ToInt32(Console.ReadLine());
ViewNumber(x, y, myArray);