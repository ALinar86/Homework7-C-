double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = (new Random().Next(-10,10) 
            + new Random().NextDouble());
    return newArray;
} 

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);