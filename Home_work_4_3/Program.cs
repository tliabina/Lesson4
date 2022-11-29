// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите длину массива ");
int n = Convert.ToInt32(Console.ReadLine());
int [] GetArray(int [] array)
{
   
   for (int i = 0; i <array.Length; i++)
   {
    array[i] = new Random().Next(-100,100);
   }
    
    return array;
}
int [] array = new int [n];
 GetArray(array);

Console.Write(String.Join(",", array));



