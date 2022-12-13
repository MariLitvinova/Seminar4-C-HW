//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// int Extent (int a, int b){
//     int product = 1;
//     for(int index = 1; b>=index; index++){
//         product = product*a;
//     }
//     return product;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = Extent(a, b);
// Console.Write($"{a} в степени {b} = {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// int Summ (int a){
//     int sum = 0;
//     while (a != 0){
//         sum += a % 10;
//         a = a / 10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Summ(a);
// Console.WriteLine($"Сумма цифр числа {a} = {result}");

// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран
Console.WriteLine("Введите длину массива");
int[] Array(){
    int [] array = new int [Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i<array.Length; i++){
        Console.WriteLine("Ведите элемент массива");
        array[i] = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
    }
   return array;
}
void ShowArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
ShowArray(Array());