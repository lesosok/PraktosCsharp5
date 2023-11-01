using Практическая__5;

int pos;

List<Cake> Shape = new List<Cake>();
Cake Krug = new Cake("Круг - ", 500);
Shape.Add(Krug);
Cake Kvadrat = new Cake("Квадрат - ", 500);
Shape.Add(Kvadrat);
Cake Pryamougolnik = new Cake("Прямоугольник - ", 500);
Shape.Add(Pryamougolnik);

List<Cake> Size = new List<Cake>();
Cake Small = new Cake("Маленький (Диаметр - 16 см, 8 порций) - ", 1000);
Size.Add(Small);
Cake Default = new Cake("Обычный (Диаметр - 18 см, 10 порций) - ", 1200);
Size.Add(Default);
Cake Big = new Cake("Большой (Диаметр - 28 см, 24 порции) - ", 2000);
Size.Add(Big);

List<Cake> Flavour = new List<Cake>();
Cake Vanila = new Cake("Ванильный - ", 100);
Flavour.Add(Vanila);
Cake Caramel = new Cake("Карамельный - ", 150);
Flavour.Add(Caramel);
Cake Coco = new Cake("Кокосовый - ", 250);
Flavour.Add(Coco);

List<Cake> Korzhi = new List<Cake>();
Cake korzh1 = new Cake("1 корж - ", 200);
Korzhi.Add(korzh1);
Cake korzha2 = new Cake("2 коржа - ", 400);
Korzhi.Add(korzha2);
Cake korzha3 = new Cake("3 коржа - ", 600);
Korzhi.Add(korzha3);

List<Cake> Glazur = new List<Cake>();
Cake Cream = new Cake("Крем - ", 100);
Glazur.Add(Cream);
Cake Drazhe = new Cake("Драже - ", 150);
Glazur.Add(Drazhe);
Cake Berries = new Cake("Ягоды - ", 200);
Glazur.Add(Berries);

List<Cake> Decor = new List<Cake>();
Cake Chocolate = new Cake("Шоколадная - ", 150);
Decor.Add(Chocolate);
Cake Berry = new Cake("Ягодная - ", 150);
Decor.Add(Berry);
Cake Creamy = new Cake("Кремовая - ", 150);
Decor.Add(Creamy);

do
{
    pos = Order.Menushka();
    if (pos == 3)
    {
        Order.Extra(Shape);
    }

    else if (pos == 4)
    {
        Order.Extra(Size);
    }

    else if (pos == 5)
    {
        Order.Extra(Flavour);
    }

    else if (pos == 6)
    {
        Order.Extra(Korzhi);
    }
    
    else if (pos == 7)
    {
        Order.Extra(Glazur);
    }

    else if (pos == 8)
    {
        Order.Extra(Decor);
    }

} while (true);