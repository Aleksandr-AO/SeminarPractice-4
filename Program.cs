/*Задача 25
Напишите цикл, который принимает на вход два числа (А и В) 
и возводит число А в натуральную степень В.

int Exponentiation(int numA, int numB)
{
    int result = 0;
    int tempor = numA;
  for (int count = 1; count < numB; count++)
  {
    result = tempor * numA;
    tempor = result;
  }
  return result;
}  

Console.WriteLine("Введите число А: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int finish = Exponentiation(firstNum, secondNum);
Console.WriteLine();
Console.WriteLine($"A ^ B = {finish}");

Задача 27
Напишите программу, которая принимает на вход число
и выдает сумму цифр в числе.

int Summ(int num)
{
int sum = 0;
int result = 0;
while (num != 0)
{
    result = num % 10;
    num = num / 10;
    sum = sum + result;
}
return sum;
}

Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int finish = Summ(user_num);
Console.WriteLine($"Сумма цифр в числе = {finish}");

Задача 29
Напишите программу, которая задает массив из 8 элементов
и выводит их на экран.
*/
int[] RandomArray (int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

int[] array = new int[8];
int[] newArray = RandomArray(array);
PrintArray(newArray);
