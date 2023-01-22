// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
PrintTask();
double[,] myArray2D = CreateArray2D();
FillArray(myArray2D);
PrintArray(myArray2D);

void PrintTask() {
    Console.WriteLine("Задайте двумерный массив размером m x n.\n"+ 
    "Программа заполнит массив случайными вещественными числами.\n");
}

double[,] CreateArray2D() {
    int Rows = 0;
    int Columns = 0;
    while (Rows < 1) {
        Console.Write("Определите количество строк (m): ");
        int.TryParse(Console.ReadLine(), out Rows);        
    }
    while (Columns < 1) {
        Console.Write("Определите количество столбцов (n): ");
        int.TryParse(Console.ReadLine(), out Columns);        
    }    
    double[,] createdArray = new double[Rows, Columns];
    return createdArray;
}

void FillArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = new Random().NextDouble()*10;
        }
    }
}

void PrintArray (double[,] array2D) {
    Console.WriteLine();
    for (int i = 0; i < array2D.GetLength(0); i++) {
        for (int j = 0; j < array2D.GetLength(1); j++) {
            Console.Write($"{array2D[i,j]:N2}  ");
        }
    Console.WriteLine("\n");
    }
}
