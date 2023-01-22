// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
PrintTask();
int[,] myArray2D = CreateArray2D();
FillArray(myArray2D);
PrintArray(myArray2D);
PrintAverageValue(myArray2D);

void PrintTask() {
    Console.WriteLine("Программа задает двумерный массив из целых чисел\n"+ 
    "и возвращает среднее арифметическое элементов в каждом столбце.\n");
}

int[,] CreateArray2D() {
    Console.Write("Для начала сформируем массив случайных целых чисел.\n");
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
    int[,] createdArray = new int[Rows, Columns];
    return createdArray;
}

void FillArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray (int[,] array2D) {
    Console.WriteLine();
    for (int i = 0; i < array2D.GetLength(0); i++) {
        for (int j = 0; j < array2D.GetLength(1); j++) {
            Console.Write($"{array2D[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintAverageValue(int[,] array2D) {
    Console.WriteLine();
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array2D.GetLength(1); i++) {
        double sumColumn = 0;
        for (int j = 0; j < array2D.GetLength(0); j++) {
            sumColumn += array2D[j,i];
        }
        Console.Write($"{sumColumn/array2D.GetLength(0):N2}");
        if (i == array2D.GetLength(1) - 1) Console.Write(".");
        else Console.Write("; ");
    }
    Console.WriteLine("\n");
}

