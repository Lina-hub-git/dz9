void Zadacha1()
{
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int i=1; 
int temp=a;
while (i<b)
{
temp = temp*a;
i=i+1;
}
Console.WriteLine("A в степени B равно: " + temp);
}


void Zadacha2()
{


Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int current_num = num;
int i=1; 
int S=0;
while (current_num>0)
{
int t=current_num%10;
S=S+t;
current_num=current_num/10;
i++;
}
Console.WriteLine($"Сумма числа {num} равна: " + S);
}




void Zadacha3()
{
int size=8;    
int[] array=new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);
}

void FillArray(int[] collection)
{
    int l=collection.Length;
    int i=0;
    while (i<l)
    {
        collection[i]=new Random().Next(-50,50);
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


void SelectionSort(int[] numb)
{
    for(int i=0; i<numb.Length-1; i++)
    {
        int min=i;
        for(int j=i+1; j<numb.Length; j++)
        {
            if(Math.Abs(numb[j])<Math.Abs(numb[min]))
            {
                min=j; 
            }
        }
        int t=numb[i];
        numb[i]=numb[min];
        numb[min]=t;
    }
}





Zadacha3();



