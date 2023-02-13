/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Getnumber(string message)
{
    Console.WriteLine(message);
    double result = 0;
    while (true)
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
            Console.WriteLine(message);
        }
    return result;
}

double k1 = Getnumber("Введите коэффициент k1");
double b1 = Getnumber("Введите коэффициент b1");
double k2 = Getnumber("Введите коэффициент k2");  
double b2 = Getnumber("Введите коэффициент b2");
double x = (b2-b1)/(k1-k2);
double y = (k1*x+b1);
Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
