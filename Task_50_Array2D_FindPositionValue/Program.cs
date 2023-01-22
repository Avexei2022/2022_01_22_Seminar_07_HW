// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
PrintTask();
double[,] myArray2D = CreateArray2D();
FillArray(myArray2D);
PrintArray(myArray2D);
PrintFindedValue(myArray2D);

void PrintTask() {
    Console.WriteLine("Программа на вход принимает позиции элемента в двумерном массиве\n"+ 
    "и возвращает значение этого элемента или же указание, что такого элемента нет.\n");
}

double[,] CreateArray2D() {
    Console.Write("Для начала сформируем массив случайных вещественных чисел.\n");
    int Rows = 0;
    int Columns = 0;
    while (Rows < 1) {
        Console.Write("Определите количество строк (m): ");
        int.TryParse(Console.ReadLine(), out Rows);        
    }
    while (Columns < 1) {
        Console.Write("Определите кличество столбцов (n): ");
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

void PrintFindedValue(double[,] array2D) {
    int i = 0;
    int j = 0;
    Console.WriteLine();
    Console.WriteLine("Для поиска элемента массива: ");
    while (i < 1) {
        Console.Write("- введите номер строки: ");
        int.TryParse(Console.ReadLine(), out i);        
    }
    while (j < 1) {
        Console.Write("- введите номер столбца: ");
        int.TryParse(Console.ReadLine(), out j);        
    }    
    Console.WriteLine();
    Console.Write($"{i} {j} -> ");
    if (i <= array2D.GetLength(0) && j <= array2D.GetLength(1)) {
        Console.WriteLine($"{array2D[i-1, j-1]:N2}\n");
    }
    else Console.WriteLine("такого числа в массиве нет");
}

