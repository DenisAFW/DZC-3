Console.WriteLine("Введите координаты первой точки X,Y и Z по очереди.");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки X,Y и Z по очереди.");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
int f = 0;
double FindLength(double f)
{
    f = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
    Console.WriteLine("Расстояние между точками равно " + f);
    return f;
}
FindLength(f);
// Легкий ужас программиста в 12 строке))