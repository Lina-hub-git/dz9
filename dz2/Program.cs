void Zadacha1()
{

    Console.WriteLine("Введите  трехзначное число Num");
    int Num = Convert.ToInt32(Console.ReadLine());


    int Num1=Num/10%10;
    Console.WriteLine(Num1);
}


void Zadacha2()
{

    // Console.WriteLine("Введите  число");
    // int i;
    //         int[] array = new int [10];
    //         i = 0;
    //         do
    //         {
    //             array[i] = Convert.ToInt32(Console.ReadLine());
    //             i=i+1;
    //         }
    //         while (Console.ReadLine() != "end");



    
    // int n=array.Length;
    // int index=2;
    // Console.WriteLine(array[index]);


// Задать с клавиатуры число элементов массива
        int n;
        Console.WriteLine("Введите число элементов числа");
        n = Convert.ToInt16(Console.ReadLine());
     // Объявим одномерный массив Data с n-элементами 
        int [] Data = new int[n];
        int i = 0;
       while (i < n)
        {
           Console.WriteLine("Введите цифры числа поочередно");
        /* Вводим элементы массива с клавиатуры 
         * и заполняем ими массив */
           Data[i] = int.Parse(Console.ReadLine());
           Console.WriteLine();
           i++;
        }
   // Вывод содержимого массива
     for (i = 0; i < n; i = i + 1)
     Console.WriteLine("Элемент[" + i + "]: " + Data[i]);
    


    
    if (n<3) 
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(Data[2]); 
    }

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





Zadacha2();


