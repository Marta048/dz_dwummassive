
Задача 1: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
int[,] array =new int[5,5];

PrintArr();
void PrintArr()
{
for (int i =0; i< array.GetLength(0);i++ )
{
  for (int j =0; j< array.GetLength(0);j++ ) 
  {
    array[i,j]=new Random().Next(1,10);
    Console.Write(array[i,j]+" ");
      
  }
  Console.WriteLine();
}
}
Console.WriteLine("Введите индекс строки массива");
int num=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца  массива");
int num1=Convert.ToInt32(Console.ReadLine());

IndexSearch();
 
void IndexSearch()
{
 bool isFind=true;
for (int i =0; i< array.GetLength(0);i++ )
{
  for (int j =0; j< array.GetLength(1);j++ ) 
  {
     if (i==num&& j==num1 ) 
     {  
      Console.Write("значение этого элемента:" +array[i,j]);  
      isFind=false;
    }

  }
}
   if(isFind==true)
    {
      Console.WriteLine("Элемента с таким индексом нет.");
    }
  
}

//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет
 //местами первую и последнюю строку массива.
int[,]array= new int[3,3];


void CreateeArr()
{
   for (int i =0; i< array.GetLength(0);i++ )
   {
      for (int j =0; j< array.GetLength(1);j++ ) 
       {
       array[i,j]=new Random().Next(1,10);
       }
   }

}

void PrntArr()
{
       for (int i =0; i< array.GetLength(0);i++ )
      {
         for (int j =0; j< array.GetLength(1);j++ ) 
          {
           Console.Write(array[i,j]+" ");
          }
        Console.WriteLine();
      }
} 

void  ChangeArray()
{
    int timeNum=0;
    int i=0;
    while ( i <array.GetLength(0))
      {
        for (int j =0; j< array.GetLength(1);j++ ) 
          {
            if(i!=1)
            {
           
             timeNum=array[0,j];
             array[0,j]=array[2,j];
             array[2,j]=timeNum;
           
            }
          }
         break;
      }
      Console.WriteLine();
     }

CreateeArr();
PrntArr();
ChangeArray();
PrntArr();



//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

using System.Globalization;

int[,] array =new int[6,8];
CreateeArr();
PrntArr();
FindMinStokArr();


void CreateeArr()
{
   for (int i =0; i< array.GetLength(0);i++ )
   {
      for (int j =0; j< array.GetLength(1);j++ ) 
       {
       array[i,j]=new Random().Next(1,10);
       }
   }

}

void PrntArr()
{
       for (int i =0; i< array.GetLength(0);i++ )
      {
         for (int j =0; j< array.GetLength(1);j++ ) 
          {
           Console.Write(array[i,j]+" ");
          }
        Console.WriteLine();
      }
} 

void FindMinStokArr()
{

int min =0;
int summ=0;
int i = 0;
int minstr=0;

  while ( i ==0)
   {
      for (int j =0; j< array.GetLength(1);j++ ) 
       {
       summ=summ+array[i,j];
       }
       Console.WriteLine( "Сумма чисел строки с индексом "+i+ " : " +summ);
       min=summ;
       minstr=i;
       i++;
   } 

   
     for (i =1; i< array.GetLength(0);i++ )
    
      {
              for (int j =0; j< array.GetLength(1);j++ ) 
               {
           
               summ=summ+array[i,j];

               }
      if(min>summ)
           {
            minstr=i;
           }
            Console.WriteLine( "Сумма чисел строки с индексом "+i+ " : " +summ );
          summ=0;
          
      }
      Console.WriteLine("Строка с индексом "+minstr+ " имеет минимальное значение");
}   

      



