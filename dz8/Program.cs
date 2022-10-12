void Zadacha1()
{
Random random=new Random();
int rows=random.Next(4,8);
int cols=random.Next(4,8);
double[,] array=new double[rows,cols];
Console.WriteLine($"количество строк в массиве {rows}, количество столбцов {cols}");
FillArray(array);
PrintArray(array);
double min=0;
for(int i=0; i<rows; i++)
   {   
        for(int j=0; j<cols; j++) 
        {
           if (array[i,j]<min)
           min=array[i,j];
           
        }
        Console.Write(Math.Round(min,2) + "\t");
    }     
}
}


void FillArray(double[,] collection)
{
    Random random=new Random();
    int rows=collection.GetLength(0);
    int cols=collection.GetLength(1);
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            collection[i,j]=random.NextDouble()*10;
        }
    }
}
void PrintArray(double[,] collection)
{
    int rows=collection.GetLength(0);
    int cols=collection.GetLength(1);
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            Console.Write(Math.Round(collection[i,j],1) +"\t");
        }
        Console.WriteLine();
    }
}


Zadacha1();
