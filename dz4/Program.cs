void Zadacha1()
{
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int i=1; 
double t=A;

while (i<B)
{
    double t = t*A;
    Console.WriteLine(t);
    i=i+1;
}


}








Zadacha1();



