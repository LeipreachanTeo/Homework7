Console.WriteLine("Введите количество строк: ");
int count_line = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int count_columns = Int32.Parse(Console.ReadLine());

int[,] two_dim_array = new int [count_line , count_columns];

Random rdm = new Random();
for (int i = 0; i < count_line; i++)
{
    for (int j = 0; j < count_columns; j++)
    {
        two_dim_array[i, j] = rdm.Next(10);
        Console.Write(two_dim_array[i,j]+ " ");
    }
    Console.WriteLine();
}

for(int j = 0; j < count_columns; j++)
{
    double sum = 0;
    double average;
    for (int i = 0; i < count_line; i++)
    {
        sum += two_dim_array[i,j];
    }
    average = sum / count_line;
    Console.WriteLine($"Среднее арифметическое {j+1} столбца {Math.Round(average,1)} ");
}