void Zadacha1()
{

    Console.WriteLine("Введите  трехзначное число Num");
    int Num = Convert.ToInt32(Console.ReadLine());


    int Num1=Num/10%10;
    Console.WriteLine(Num1);
}


void Zadacha2()
{

    Console.WriteLine("Введите  трехзначное число Num");
    int Num = Convert.ToInt32(Console.ReadLine());


    int Num1=Num/10%10;
    Console.WriteLine(Num1);
}



void Zadacha3()
{

    Console.WriteLine("Введите число от 1 до 7");
    int DenNedeli = Convert.ToInt32(Console.ReadLine());

    if ((DenNedeli==6) || (DenNedeli==7))
    {
        Console.WriteLine("выходной день");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
    
}





Zadacha3();

