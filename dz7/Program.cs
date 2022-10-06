void Zadacha1()
{
Random random=new Random();
int rows=random.Next(4,8);
int cols=random.Next(4,8);
double[,] array=new double[rows,cols];
Console.WriteLine($"{rows} {cols}");
FillArray(array);
PrintArray(array);
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



void Zadacha2()
{
Random random=new Random();
int rows=random.Next(4,6);
int cols=random.Next(4,6);
double[,] array=new double[rows,cols];
Console.WriteLine($"число строк в массива {rows} , число столбцов в массиве {cols}");
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());
if (i<rows && j<cols)  Console.WriteLine($"число в массиве {Math.Round(array[i,j],1)}");
else Console.WriteLine("такого числа в массиве нет");

}





void Zadacha3()
{
Random random=new Random();
int rows=random.Next(2,4);
int cols=random.Next(2,4);
int[,] array=new int[rows,cols];
Console.WriteLine($"{rows} {cols}");
FillaArray(array);
PrintaArray(array);
int sum=0;
double avg=0;

for(int j=0; j<cols; j++)
    {
    for(int i=0; i<rows; i++)
        {
           sum=sum+array[i,j];
           Console.Write(sum +"\t");
           avg=Convert.ToDouble(sum/rows);
            //Console.Write(avg+"\t");
        }
       // Console.Write(Math.Round(avg,2) + "\t"); 
    }     
}


void FillaArray(int[,] collection)
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
void PrintaArray(int[,] collection)
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

Zadacha3();

