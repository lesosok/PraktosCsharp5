using Практическая__5;

int makaron = 1;
ConsoleKeyInfo key;
int pos;
Order order = new();

List<Cake> Shape = new()
{
    new Cake("Круг - ", 500),
    new Cake("Квадрат - ", 500),
    new Cake("Прямоугольник - ", 500)
};

List<Cake> Size = new()
{
    new Cake("Маленький (Диаметр - 16 см, 8 порций) - ", 1000),
    new Cake("Обычный (Диаметр - 18 см, 10 порций) - ", 1200),
    new Cake("Большой (Диаметр - 28 см, 24 порции) - ", 2000)
};

List<Cake> Flavour = new()
{
    new Cake("Ванильный - ", 100),
    new Cake("Карамельный - ", 150),
    new Cake("Кокосовый - ", 250)
};

List<Cake> Korzhi = new()
{
    new Cake("1 корж - ", 200),
    new Cake("2 коржа - ", 400),
    new Cake("3 коржа - ", 600)
};

List<Cake> Glazur = new()
{
    new Cake("Крем - ", 100),
    new Cake("Драже - ", 150),
    new Cake("Ягоды - ", 200)
};

List<Cake> Decor = new()
{
    new Cake("Шоколадная - ", 150),
    new Cake("Ягодная - ", 150),
    new Cake("Кремовая - ", 150)
};

do
{
    pos = order.Menushka();

    switch (pos)
    {
        case 3:
            order.Extra(Shape);
            break;

        case 4:
            order.Extra(Size); 
            break;

        case 5:
            order.Extra(Flavour);
            break;

        case 6:
            order.Extra(Korzhi);
            break;

        case 7:
            order.Extra(Glazur);
            break;

        case 8:
            order.Extra(Decor);
            break;

        case 9:
            Console.Clear();

            Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите на клавишу Escape");

            Order.FileCreation(order.FullOrder, order.FullCost);

            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                order.FullOrder = " ";
                order.FullCost = 0;
                order.Menushka();
            }

            else
            {
                makaron = 0;
            }

            break;
    }
} while (makaron != 0);