Console.WriteLine("Введите пятизначное число");
int t = Convert.ToInt32(Console.ReadLine());

int t1=t/10000;
int t2=t/1000%10;
int t4=t/10%10;
int t5=t%10;

Console.WriteLine(t1,t2,t4,t5);
