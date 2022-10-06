void Zadacha1()
{
Random random=new Random();
int rows=random.Next(4,8);
int cols=random.Next(4,8);
int[,] array=new int[rows,cols];



FillArray(array);
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
            Console.WriteLine(collection[i,j]+"\t";
        }
    }
}




Zadacha1();

