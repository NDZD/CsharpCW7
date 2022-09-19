// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4

System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());




int [,] CreateArray(int rows, int columns){
    int [,] arr = new int[rows,columns];

    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            arr [i,j] = new Random().Next(100);
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return arr;
}


int [,] arr = CreateArray(m, n);
System.Console.WriteLine();
for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            if(i % 2 == 0 && j % 2 ==0){
                arr[i,j] *= arr[i,j];
            }
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    

    