// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
Console.Write("Какое количество чисел, Вы желаете ввести? -> ");
count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int i = 0;
int sum = 0;

while(i < count)
{
  Console.Write($"Введите число #{i+1}: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
  i++;
}

Console.WriteLine(String.Join(", ", array));

for (int a = 0; a < array.Length; a++)
{
  if(array[a] >0)
  {
    sum += 1; 
  }
}

Console.WriteLine($"Количество положительных чисел, равно: {sum}");