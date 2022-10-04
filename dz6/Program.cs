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



Zadacha1();

