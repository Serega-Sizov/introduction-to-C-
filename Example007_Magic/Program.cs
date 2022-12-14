Console.Clear();
//следующей строкой показываем как ставится точка с координатами х=10, у=4.
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

//задаем координаты точки
int x = xa, y = xb;

//задаем счетчик
int count = 0;

//условие
while(count < 10000)
{
//генерируем случайное число, what имя точки
int what = new Random().Next(0, 3); //[0;3) 0 1 2 полуинтервал от 0 до 3
if(what == 0)
{
    x = (x + xa) / 2;
    y = (y + ya) / 2;
}

if(what == 1)
{
    x = (x + xb) / 2;
    y = (y + yb) / 2;
}

if(what == 2)
{
    x = (x + xc) / 2;
    y = (y + yc) / 2;
}

Console.SetCursorPosition(x, y);
Console.WriteLine("*");
count = count + 1;

}
