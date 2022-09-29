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



Zadacha2();



