using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Считываем содержимое файла
        string[] lines = File.ReadAllLines("nums.txt");

        // Преобразуем строки в числа, разделяя их по пробелу
        int[] numbers = lines.SelectMany(line => line.Split(' ')).Select(int.Parse).ToArray();

        // Удаляем все четные числа
        numbers = numbers.Where(x => x % 2 != 0).ToArray();

        // Преобразуем массив обратно в строку, разделяя числа по пробелу
        string result = string.Join(" ", numbers);

        // Записываем результат обратно в файл
        File.WriteAllText("nums.txt", result);
    }
}
