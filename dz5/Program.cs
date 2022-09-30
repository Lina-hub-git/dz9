void Zadacha1()
{
int size=8;    
double[] array=new double[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int k=ChetnieSort(array);
Console.WriteLine("количество четных чисел = " + k);
}
void FillArray(double[] collection)
{
    int l=collection.Length;
    int i=0;
    while (i<l)
    {
        collection[i]=new Random().Next(100,1000);
        i++;
    }
}
void PrintArray(double[] col)
{
    int d=col.Length;
    int i=0;
    while (i<d)
    {
        Console.Write(col[i] + "  ");
        i++;
    }
}
int ChetnieSort(double[] numb)
{
    int k=0;
    for(int i=0; i<numb.Length; i++)
    {
        if (numb[i]%2==0)
        {
            k++;
        }
    }
        return k;  
}


void Zadacha2()
{
int size=5;    
double[] array=new double[size];
FillaArray(array);
PrintArray(array);
Console.WriteLine();
double S=NeChetnieIndex(array);
Console.WriteLine("сумма элементов с нечетными индексами = " + S);
}
void FillaArray(double[] collection)
{
    int l=collection.Length;
    int i=0;
    while (i<l)
    {
        collection[i]=new Random().Next(-10,10);
        i++;
    }
}
double NeChetnieIndex(double[] numb)
{
    double S=0;
    for(int i=0; i<numb.Length; i=i+2)
    {
        S=S+numb[i];
    }
        return S;  
}






void Zadacha3()
{
int size=5;    
double[] array=new double[size];
FillaArray(array);
PrintArray(array);
Console.WriteLine();
double min=Razniza(array);
double max=Razniza(array);
double R=Razniza(array);
Console.WriteLine("разница между макс и мин = " + R);

}


double Razniza(double[] numb)
{
    double min=numb[0];  double max=0;
    for(int i=1; i<numb.Length; i++)
    {
        if (numb[i]>max)  max=numb[i];

        if (numb[i]<min)  min=numb[i];
    }
    double R=max-min;
        return R; 
}


Zadacha3();




