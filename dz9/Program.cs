
void Zadacha1()
{
   int rezult=0;
Console.WriteLine("задайте число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N");
int n = Convert.ToInt32(Console.ReadLine());
Kratno_trem(m,n,rezult);

}

int Kratno_trem(int m, int n, int rezult=0)
{
    if (m>n) return rezult;
    if (m%3==0) Console.Write($"число кратное трем: {m} , ");
    m++;
    return Kratno_trem(m,n,rezult);
}


void Zadacha2()
{ 
   int sum=0; 
Console.WriteLine("задайте число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(m,n,sum));

}

int Summa(int m, int n,  int sum=0)
{   
    if (m>n) 
    {
        Console.WriteLine($"Сумма = {sum}");
        return sum; 
    }    
    sum=sum+m;
    m++;
    return Summa(m,n,sum);
}


Zadacha2();

