void Zadacha1()
{
Random random=new Random();
int rows=random.Next(4,8);
int cols=random.Next(4,8);
int[,] array=new int[rows,cols];
Console.WriteLine($"количество строк в массиве {rows}, количество столбцов {cols}");
FillArray(array);
PrintArray(array);

int temp;
for(int i=0; i<rows; i++)
   {   
        for(int j=0; j<cols; j++) 
        {
            for (int k=j+1; k<cols; k++)
                if (array[i,j]<array[i,k])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,k];
                    array[i,k]=temp;
                }
        }

    } 
  Console.WriteLine($"упорядоченный массив по убыванию по строкам");
  PrintArray(array);     
}


void FillArray(int[,] collection)
{
    Random random=new Random();
    int rows=collection.GetLength(0);
    int cols=collection.GetLength(1);
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            collection[i,j]=random.Next(-10,10);
        }
    }
}
void PrintArray(int[,] collection)
{
    int rows=collection.GetLength(0);
    int cols=collection.GetLength(1);
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            Console.Write(collection[i,j] +"\t");
        }
        Console.WriteLine();
    }
}





void Zadacha2()
{
Random random=new Random();
int rows=random.Next(2,4);
int cols=random.Next(2,4);
int[,] array=new int[rows,cols];
Console.WriteLine($"количество строк в массиве {rows}, количество столбцов {cols}");
FillArray(array);
PrintArray(array);
int[] t=new int[cols];
int sum=0;
for(int i=0; i<rows; i++)
   {    sum=0;
        for(int j=0; j<cols; j++)
        {
           sum=sum+array[i,j];
           t[i]=sum;
        }
        Console.WriteLine($" сумма в {i+1} строке = {sum}");  
    }  
 



   int min = t[0], minIndex = 0;
for (int i = 0; i < rows; i++)
{
	if (min > t[i])
	{
		min = t[i];
		minIndex = i;
	}
}

Console.Write($"наименьшая сумма в {minIndex+1} строке ");  


}



Zadacha2();

