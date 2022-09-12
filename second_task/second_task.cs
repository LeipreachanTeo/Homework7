Console.WriteLine("Введите позицию строки в двумерном массиве: ");
int line_search = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца в двумерном массиве ");
int column_search = Int32.Parse(Console.ReadLine());
int rdm_line = new Random().Next(3,4);
int rdm_column = new Random().Next(3,4);
int[,] two_dim_array = new int [ rdm_line,rdm_column ];

for (int i = 0; i < rdm_line; i++)
{
    for (int j = 0; j < rdm_column; j++)
    {
        two_dim_array[i, j] = new Random().Next(99);
        Console.Write(two_dim_array[i,j]+ " ");
    }
    Console.WriteLine();
}
if (line_search >= 0 && line_search < rdm_line && column_search >= 0 && column_search < rdm_column)
     Console.WriteLine($"Число на позиции[{line_search}:{column_search}] является {two_dim_array[line_search, column_search]} ");
else
    Console.WriteLine($"Числа на позиции [{line_search}:{column_search}] не существует");