using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        int j = 8;

        // Відкриваємо файли для читання та запису
        using (StreamReader reader = new StreamReader("input.txt"))
        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Перевіряємо, чи і-те прізвище містить символ j
                if (line.Length > j && line[j] != ' ')
                {
                    // Записуємо прізвище у файл output
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Роботу завершено. Для перевірки відкрийте output.txt");
    }
}










