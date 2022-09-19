// **Задача 51:** Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12


System.Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());




int [,] CreateArray(int rows, int columns){
    int [,] arr = new int[rows,columns];

    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            arr [i,j] = new Random().Next(10);
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return arr;
}



int [,] arr = CreateArray(m,n);
int result = 0;
System.Console.WriteLine();
for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            if(i == j ){
                result = result + arr[i,j];
            }
            //System.Console.Write($"{arr[i,j]} ");
        }
        //System.Console.WriteLine();
    }
    System.Console.WriteLine("Сумма элементов главной диагонали = " + result);