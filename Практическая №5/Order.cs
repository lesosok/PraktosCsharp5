using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    internal class Order
    {
        string FullOrder = "";
        int FullCost = 0;

        public static int Menushka()
        {
            Console.Clear();

            Console.WriteLine("Заказ тортов в ГЛАЗУРЬКА, торты на ваш выбор");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус торта");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("");
            Console.WriteLine("Цена: " + FullCost);
            Console.WriteLine("Ваш торт: ");

            ConsoleKeyInfo key;
            do
            {
                int pos = Menu.Show(3, 9);

                if (pos == 9)
                {
                    Console.Clear();

                    Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите на клавишу Escape");

                    FileCreation(FullOrder, FullCost);

                    key = Console.ReadKey();

                }

                return pos;

                key = Console.ReadKey();

            } while (key.Key != ConsoleKey.Escape);
        }

        void FileCreation(string FullOrder, int FullCost)
        {
            string path = "D:\\Рабочий стол\\MyFile.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            File.AppendAllText("D:\\Рабочий стол\\MyFile.txt", "Заказ от " + DateTime.Now + "\nЗаказ: " + FullOrder + "\nЦена: " + FullCost + "\n");
        }

        public static void Extra(List<Cake> list)
        {
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();

                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт из меню:");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");

                foreach (Cake cake in list)
                {
                    Console.WriteLine("  " + cake.cakename + cake.cost);
                }

                int pos = Menu.Show(3, 5);

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    FullOrder += list[pos].cakename + "" + list[pos].cost + "; ";
                    FullCost += list[pos].cost;

                    Menushka();
                }

            } while (key.Key != ConsoleKey.Escape);

            Menushka();
        }
    }
}
