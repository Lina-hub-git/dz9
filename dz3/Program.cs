void Zadacha1()
{


Console.WriteLine("Введите пятизначное число");
int t = Convert.ToInt32(Console.ReadLine());

int t1=t/10000;
int t2=t/1000%10;
int t4=t/10%10;
int t5=t%10;

if (t/100000!=0 || t/10000==0)
{
    Console.WriteLine("вы ввели не пятизначное число ");
}
else if (t1==t5 && t2==t4)
    {
        Console.WriteLine(" число  полином"); 
    }
    else 
    {
       Console.WriteLine("число не полином ");
    }   
}






void Zadacha2()
{

    Console.WriteLine("Введите координаты точки А(x,y,z)");
    int xa = Convert.ToInt32(Console.ReadLine());
    int ya = Convert.ToInt32(Console.ReadLine());
    int za = Convert.ToInt32(Console.ReadLine());   


    Console.WriteLine("Введите координаты точки B(x,y,z)");
    int xb = Convert.ToInt32(Console.ReadLine());
    int yb = Convert.ToInt32(Console.ReadLine());
    int zb = Convert.ToInt32(Console.ReadLine());   

    double d = Math.Sqrt(Math.Pow((xb-xa),2) +  Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
    Console.WriteLine(d);
}



void Zadacha3()
{
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int i=1; 
while (i<=N)
{
    double t = Math.Pow(i,3);
    Console.WriteLine(t);
    i=i+1;
}

if (N<0)
{
     Console.WriteLine("необходимо ввести положительное число");
}

}








Zadacha3();


