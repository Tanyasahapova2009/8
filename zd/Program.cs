Console.WriteLine("Выберите задание:");
Console.WriteLine("Задача 1. Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Задание 2. Находит строку с наименьшей суммой элементов.");
Console.WriteLine("Задание 3. Программа, которая будет находит произведение двух матриц ");
Console.WriteLine("Задание 4. Трёхмерный массив из неповторяющихся двузначных чисел. ");
Console.WriteLine("Задание 5. Программа, которая заполнит спирально массив 4 на 4. ");
int z = Convert.ToInt32(Console.ReadLine());
switch (z)
{
    case 1:
      Task1();
      break;
    case 2:
    Task2();
    break;
    case 3:
    Task3();
    break;
     case 4:
    Task4();
    break;
     case 5:
    Task5();
    break;
   
      default:
      break;
}
void Task1()
{
Console.WriteLine("Введите М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());

 
 
 int[,]array2d1= new int[m,n];

int[]array= new int[n];
 Random random = new Random();

 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d1[i,j]= random.Next(1,11);
    Console.Write(array2d1[i,j] + "  ");
    }
    Console.WriteLine();
 }
 Console.WriteLine();
  Console.WriteLine("Отсортированный массив");
 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array[j]=array2d1[i,j];
   
    }
   Array.Sort(array);
Array.Reverse(array);
for (int j = 0; j<n; j++)
{
   Console.Write(array[j] + "  ");
}
    Console.WriteLine();
 }

}


void Task2()
{
  
Console.WriteLine("Введите М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());
int summin=0;
  int a=1;
 int sum=0;
 
 int[,]array2d1= new int[m,n];

 Random random = new Random();

 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d1[i,j]= random.Next(1,11);
    Console.Write(array2d1[i,j] + "  ");
    }
    Console.WriteLine();
 }
  
 for (int i =0; i< m; i++)
 {sum = 0;
    for (int j = 0; j<n; j++)
    {
    sum = sum + array2d1[i,j];
    if (i==0)
    summin=sum;
    }
   if(sum<summin)
   {
      summin=sum;
      a = i+1;
      
   }
    
}
Console.Write($"наименьшая сумма чисел в строке {summin} ");
Console.WriteLine();
Console.Write($"строкa с наименьшей суммой элементов: {a} строка");

}


void Task3()
{
  Console.WriteLine("Введите М и N");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());

 int[,]array2d1= new int[m,n];
int[,]array2d2= new int[m,n];
int[,]array2d3= new int[m,n];

 Random random = new Random();
Console.WriteLine("Первая матрица");
 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d1[i,j]= random.Next(1,11);
    Console.Write(array2d1[i,j] + "  ");
    }
    Console.WriteLine();
 }
 
Console.WriteLine("Вторая матрица");
  for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d2[i,j]= random.Next(1,11);
    Console.Write(array2d2[i,j] + "  ");
    }
    Console.WriteLine();
 }
  
  Console.WriteLine("произведение двух матриц");
  for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
    array2d3[i,j]=array2d1[i,j] * array2d2[i,j];
    Console.Write(array2d3[i,j] + "  ");
    }
    Console.WriteLine();
 }
  


}



void Task4()
{
     Console.WriteLine("Введите М,N,T");
 int m=Convert.ToInt32(Console.ReadLine());
 int n=Convert.ToInt32(Console.ReadLine());
 int t=Convert.ToInt32(Console.ReadLine());
 int[,,]array3d1= new int[m,n,t];

 int a= 15;

 for (int i =0; i< m; i++)
 {
    for (int j = 0; j<n; j++)
    {
      for (int k=0; k<t ; k++)
      {
    array3d1[i,j,k]= a;
    a=a+3;
    Console.Write(array3d1[i,j,k] + "(" + i + "," + j + "," + t + ")"+ "  ");
        }
    Console.WriteLine();

     }
 }
}



void Task5()
{
  int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}



}


