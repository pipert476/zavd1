using System;
using System.Text;

class Program
{

    [Flags]
    enum Goods
    {
        None = 0,
        Techno1 = 1 << 0,
        Techno2 = 1 << 1,
        Techno3 = 1 << 2,
        Techno4 = 1 << 3,
        Techno5 = 1 << 4,
        Techno6 = 1 << 5,
        Techno7 = 1 << 6,
        Techno8 = 1 << 7,
        Techno9 = 1 << 8,
    }

    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;

        // Заповнення переліку товарів
        string[] goodsNames = new string[]
        {
            "Холодильник;",
            "Пральна машина;",
            "Чайник;",
            "Принтер;",
            "Сканер;",
            "Проектор;",
            "Ноутбуки;",
            "Клавіатури;",
            "Комп'ютерні миші."

        };

        // Вивід переліку товарів з використанням констант
        Console.WriteLine("Побутова техніка:");
        Console.WriteLine("Номер - Назва");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1} - {goodsNames[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("Оргтехніка:");
        Console.WriteLine("Номер - Назва");
        for (int i = 3; i < 6; i++)
        {
            Console.WriteLine($"{i + 1} - {goodsNames[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("Комп'ютери і комплектуючі:");
        Console.WriteLine("Номер - Назва");
        for (int i = 6; i < goodsNames.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {goodsNames[i]}");
        }

        // Введення номерів товарів, які користувач хоче придбати
        Console.WriteLine("Введіть номери товарів через кому (1 - 9):");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(',');
        Goods selectedGoods = Goods.None;

        // Перетворення введених номерів у флаги перерахування
        foreach (var number in inputNumbers)
        {
            if (int.TryParse(number, out int parsedNumber) && parsedNumber > 0 && parsedNumber <= goodsNames.Length)
            {
                selectedGoods |= (Goods)(1 << (parsedNumber - 1));
            }
        }

        // Вивод вибраних товарів
        Console.WriteLine("");
        Console.WriteLine("Ви вибрали наступні товари:");
        if ((selectedGoods & Goods.Techno1) != 0)
        {
            Console.WriteLine(goodsNames[0]);
        }
        if ((selectedGoods & Goods.Techno2) != 0)
        {
            Console.WriteLine(goodsNames[1]);
        }
        if ((selectedGoods & Goods.Techno3) != 0)
        {
            Console.WriteLine(goodsNames[2]);
        }
        if ((selectedGoods & Goods.Techno4) != 0)
        {
            Console.WriteLine(goodsNames[3]);
        }
        if ((selectedGoods & Goods.Techno5) != 0)
        {
            Console.WriteLine(goodsNames[4]);
        }
        if ((selectedGoods & Goods.Techno6) != 0)
        {
            Console.WriteLine(goodsNames[5]);
        }
        if ((selectedGoods & Goods.Techno7) != 0)
        {
            Console.WriteLine(goodsNames[6]);
        }
        if ((selectedGoods & Goods.Techno8) != 0)
        {
            Console.WriteLine(goodsNames[7]);
        }
        if ((selectedGoods & Goods.Techno9) != 0)
        {
            Console.WriteLine(goodsNames[8]);
        }






        // Вивід прізвища автора
        Console.WriteLine("Автор програми: Ніколаєв Д.С.");
    }
}

















































/*
 *   string[] pobutt = new string[]
        {
            "Холодильник;",
            "Пральна машина;",
            "Чайник."

        };

        string[] orgg = new string[]
        {

            "",
            "",
            "",
            "Принтер;",
            "Сканер;",
            "Проектор."

        };

        string[] komp = new string[]
        {


            "",
            "",
            "",
            "",
            "",
            "",
            "Ноутбуки;",
            "Клавіатури;",
            "Комп'ютерні миші."
         
        };

        // Вивід переліку товарів з використанням констант
        Console.WriteLine("Побутова техніка:");
        Console.WriteLine("Номер - Назва");
        for (int i = 0; i < pobutt.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {pobutt[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("Оргтехніка:");
        Console.WriteLine("Номер - Назва");
        for (int i = 3; i < orgg.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {orgg[i]}");
        }

        Console.WriteLine("");
        Console.WriteLine("Комп'ютери і комплектуючі:");
        Console.WriteLine("Номер - Назва");
        for (int i = 6; i < komp.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {komp[i]}");
        }
 * 
 * 
 * 
 * 
 * 
 *      [Flags]
    enum Goods
    {
        None = 0,
        Pobutova = 2 << 0,
        Office = 6 << 2,
        Computers = 9 << 6
    }











Console.WriteLine("Ви вибрали наступні товари:");
        if ((selectedGoods & Goods.Pobutova) != 0)
        {
            Console.WriteLine(goodsNames[0]);
        }
        if ((selectedGoods & Goods.Office) != 0)
        {
            Console.WriteLine(goodsNames[1]);
        }
        if ((selectedGoods & Goods.Computers) != 0)
        {
            Console.WriteLine(goodsNames[2]);
        }


 * 
 * 
 * 
 * 
 * 
 */



