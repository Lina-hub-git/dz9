void Zadacha1()
{
Console.WriteLine("Введите количество чисел M");
int m = Convert.ToInt32(Console.ReadLine());
int[] array=new int[m];
Console.WriteLine("Введите числа с клавиатуры");
FillaArray(array);
int k=0;
for(int i=1; i<m; i++)
{
    if (array[i]>0) k++;
}
Console.WriteLine("количество положительных чисел = " + k);
}
void FillaArray(int[] collection)
{
    int l=collection.Length;
    int i=0;
    while (i<l)
    {
        collection[i]=Convert.ToInt32(Console.ReadLine());
        i++;
    }
}

void Zadacha2()
{
Console.WriteLine("задайте коэффициенты y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите b1, k1");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2, k2");
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
double x1=b2-b1;
double x2=k1-k2;
double x=x1/x2;
double y=k1*x+b1;

Console.WriteLine("точка пересечения двух прямых = (" + x + ", "+y+")");
}

Zadacha2();

