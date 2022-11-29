// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

//Console.WriteLine("Введите число А: ");
//int A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число B: ");
//int B = Convert.ToInt32(Console.ReadLine());

//double resalt = Math.Pow(A,B);
//Console.WriteLine(resalt);


Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int GetPower(int a, int b)
{
  int sum = a;
  for (int i = 1; i < b; i++)
  {
    sum = sum * a;
  }
  return sum;
}

Console.WriteLine(GetPower(A, B));










