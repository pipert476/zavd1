using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sentence = "Застиглi очi уважно розглядали цi скарби, наче втомлене море дивиться на свої перлини та острови.";

        // Розбиваємо речення на окремі слова
        string[] words = sentence.Split(' ', ',', '.', '!', '?');

        // Сортуємо слова за спаданням довжини
        var sortedWords = words.OrderByDescending(word => word.Length);

        // Виводимо слова у порядку спадання довжини
        Console.WriteLine("Слова у порядку спадання довжини:");
        foreach (var word in sortedWords)
        {
            Console.WriteLine(word);
        }
    }
}
