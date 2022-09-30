void Zadacha1()
{
int size=8;    
int[] array=new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChetnieSort(array);

}

void FillArray(int[] collection)
{
    int l=collection.Length;
    int i=0;
    while (i<l)
    {
        collection[i]=new Random().Next(100,1000);
        i++;
    }
}

void PrintArray(int[] col)
{
    int d=col.Length;
    int i=0;
    while (i<d)
    {
        Console.Write(col[i] + "  ");
        i++;
    }
}


int ChetnieSort(int[] numb)
{
    for(int i=0; i<numb.Length; i++)
    {
        k=0;
        if (numb[i]%2==0)
            k++;
    }
    Console.WriteLine(k);

}





Zadacha1();




