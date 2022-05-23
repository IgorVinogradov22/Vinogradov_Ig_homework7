//Заполнить массив спиральным способом.
Console.WriteLine("Введите число строк массива ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива ");
int b =Convert.ToInt32(Console.ReadLine());

//Создать двумерный массив. 

int[,] CreateArray (int a, int b)
{
    int[,]arr = new int [a,b];
    for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = new Random ().Next (1,10);
                        
                    }
                    
                                      
                }
                return arr;

}

//Вывод массива в консоль.

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Заполнение строк и столбцов по спирали.


int [,] FillSpiralArray (int[,]array)
{
    int W = array.GetLength(0); //строки
    int Z = array.GetLength(1); //столбцы

    int xi =0; int yi =0;
    int xj =0; int yj =0;
    
    int n = 1;
    int i = 0;
    int j = 0;

       while ( n<= W * Z)
          
     {
        array[i,j]= n;        

            if (i == xi && j < W - yj -1)
            ++j;
        else if (j== W - yj -1 && i < Z - yi -1)
            ++i;
        else if (i == Z - yi -1 && j > xj)
            --j;
        else
            --i;

        if ((i == xi + 1) && (j == xj) && (xj != W - yj - 1))
        {
            ++xi;
            ++yi;
            ++xj;
            ++yj;
        }
        ++n;
    }
    return array;
}

//Вывод массива в консоль.

void PrintSpiralArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] inArr = CreateArray (a, b);
PrintArr(inArr);
int[,] array = FillSpiralArray (inArr);
PrintSpiralArr (inArr);







    

