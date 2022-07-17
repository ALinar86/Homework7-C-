int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 10);
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

void ArithmeticMean(int[,] array)
{
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double result = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
            result = sum / array.GetLength(0);
        }
        Console.Write($"{result}; ");
    }
 
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
ArithmeticMean(myArray);