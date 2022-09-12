// // Принять на вход коодинаты двух точек
// и найти расстояние между ними в трехмерном пространстве

Console.WriteLine ("Введите координаты первой точки");
int X1 = Convert.ToInt16(Console.ReadLine());
int Y1 = Convert.ToInt16(Console.ReadLine());
int Z1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки");
int X2 = Convert.ToInt16(Console.ReadLine());
int Y2 = Convert.ToInt16(Console.ReadLine());
int Z2 = Convert.ToInt16(Console.ReadLine());

double Result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow (Z2 - Z1, 2));
Console.Write($"Расстояние между точками равно {Result}");