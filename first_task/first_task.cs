Console.WriteLine("Введите количество строк: ");
int n = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Int32.Parse(Console.ReadLine());

double[,] two_dim_array = new double [n , m];

Random rdm = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        two_dim_array[i, j] = rdm.Next(-10,10) + Math.Round(rdm.NextDouble(),1);
        Console.Write(two_dim_array[i,j]+ " ");
    }
    Console.WriteLine();
}
