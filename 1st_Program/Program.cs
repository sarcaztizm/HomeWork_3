// Принять на вход пятизначное число
// и проверить является ли оно палиндромом

Console.WriteLine ("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number / 10000 != 0 && Number / 10000 < 10) // проверили что число пятизначное
{
   if (Number / 10000 == Number % 10)
   {
    Number /= 10;
    Number %= 1000;
    if (Number / 100 == Number %10)
        Console.Write ("Число является палиндромом");
    else
        Console.Write ("Число не палиндром");
   }
   else
    Console.Write ("Число не палиндром");
}
else 
    Console.WriteLine ("Введено неправильное число");
