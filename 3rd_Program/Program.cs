// Программа принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N

Console.WriteLine ("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= N)
{
    Console.Write ($" {Math.Pow(count, 3)} ");
    count++;
}
