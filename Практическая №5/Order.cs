using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    public class Order
    {
        public string FullOrder = " ";
        public int FullCost = 0;

        public int Menushka()
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
            Console.WriteLine("Ваш торт: " + FullOrder);

            int pos = Menu.Show(3, 9);
            return pos;
        }

        public void Extra(List<Cake> list)
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
                    FullOrder += list[pos - 3].cakename + "" + list[pos - 3].cost + "; ";
                    FullCost += list[pos - 3].cost;
                }
                break;

            } while (key.Key != ConsoleKey.Escape);
        }

        public static void FileCreation(string FullOrder, int FullCost)
        {
            string path = "C:\\Новая папка (2)\\MyFile.txt";

            if (File.Exists(path))
            {
                File.AppendAllText(path, "Заказ от " + DateTime.Now + "\nЗаказ: " + FullOrder + "\nЦена: " + FullCost + "\n");
            }

            else
            {
                File.Create(path);
                Console.Clear();
                Console.WriteLine("\nУпс!\nПохоже у вас отсутствовал путь 'C:\\Новая папка (2)\\MyFile.txt'. Из-за этого ваш заказ не сохранился. Однако сейчас путь добавился и при вашем следующем заказе данные о нём сохранятся в файл! Но перед этим вам нужно перезапустить программу (Для закрытия программы нажмите любую клавишу, кроме Escape)");
            }
        }
    }
}
