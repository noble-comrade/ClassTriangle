/*
*-------------------------------------------------------------------------------
*--_______---_____-----_-------_-------_----_----______----_---------________---
*-|__   __|-|      \--|_|-----/ \-----|  \ | |--/ _____\--| |--------|  _____|--
*----| |----|  ( )  |--_-----/ _ \----|   \| |-| /----__--| |--------| |_____---
*----| |----|  _   /--| |---/ /_\ \---| |\   |-| |---|_ |-| |-----_--|  _____|--
*----| |----| |-\ \---| |--/ _____ \--| | \  |-| \____/ |-| |____| |-| |_____---
*----|_|----|_|--\_\--|_|-/_/     \_\-|_|  |_|--\______/--|________|-|_______|--
*-------------------------------------------------------------------------------
*/
int a, b, c,h;
while (true) 
{
    string key;
    Console.Write("Выберите фигуру:\n1)Треугольник;\n2)Пирамида;\n3)Треугольная призма.\nВведите цифру(или q чтобы выйти) >> ");
    key = Console.ReadLine();
    if (key == "q") break;
    else if (key == "1")
    {
        Console.WriteLine("Треугольник.");
        while (true)
        {
            Console.Write("Сторона А = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона B = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона C = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c || b + c == a || c + a == b) Console.WriteLine("Такого треугольника не существует! Попробуйте ещё раз ввести значения.");
            else break;
        }
        var triangle = new Triangle(a,b,c);
        triangle.Print();
    }
    else if (key == "2") 
    {
        Console.WriteLine("Пирамида.");
        while (true)
        {
            Console.Write("Сторона А = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона B = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона C = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c || b + c == a || c + a == b) Console.WriteLine("Такого треугольника не существует! Попробуйте ещё раз ввести значения.");
            else break;
        }
        Console.Write("Сторона h = ");
        h = Convert.ToInt32(Console.ReadLine());
        var pyramid = new Pyramid(a,b,c,h);
        pyramid.Print();
    }
    else
    {
        Console.WriteLine("Треугольная призма.");
        while (true)
        {
            Console.Write("Сторона А = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона B = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сторона C = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b == c || b + c == a || c + a == b) Console.WriteLine("Такого треугольника не существует! Попробуйте ещё раз ввести значения.");
            else break;
        }
        Console.Write("Сторона h = ");
        h = Convert.ToInt32(Console.ReadLine());
        var prism = new TriangularPrism(a,b,c,h);
        prism.Print();
    }
}
class Triangle 
{
    private int a;
    private int b;
    private int c;
    private string name = "треугольника";
    public Triangle(int a, int b, int c) { this.a = a; this.b = b; this.c = c; }
    public int P() { return a + b + c; }
    public virtual double S() 
    {
        double p = (a + b + c) / 2;
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return Math.Round(s);
    }
    public void Print() => Console.WriteLine($"Периметр {name} = {P()}; Площадь {name} = {S()}.");
}
class Pyramid : Triangle 
{
    private string name;
    private int a;
    private int b;
    private int c;
    private int h;
    public Pyramid(int a, int b, int c, int h) : base(a,b,c) { this.h = h; }
    public override double S() 
    {
        double p = (a + b + c) / 2;
        double sg = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return sg+(this.P()*h)/2;
    }
}
class TriangularPrism : Triangle 
{
    private string name;
    private int a;
    private int b;
    private int c;
    private int h;
    public TriangularPrism(int a, int b, int c, int h) : base(a, b, c) { this.h = h; }
    public override double S() 
    {
        return this.P()*h;
    }
}
