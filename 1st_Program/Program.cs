// Принять на вход пятизначное число
// и проверить является ли оно палиндромом

Console.WriteLine ("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number / 10000 != 0) // проверили что число пятизначное
{
    int Number1 = Number;
    if (Number / 10000 == Number % 10) // проверка равенства первой и последней цифры числа
    {
        Number %=  10000;
        Number /= 10;
    }
    else 
        Console.Write ($"Число {Number} не палиндром");
    if (Number / 100 == Number %10)
        Console.Write ($"Число {Number1} является палиндромом");
    else
        Console.Write ($"Число {Number1} не является палиндромом");
}
else 
    Console.WriteLine ("Введено неправильное число");
