// Написать программу полуение квадрата вводного числа
// 1. Запросить у пользователя число, записать число в переменную
// 2. Возвести полученное число в квадрат
// 3. Вывести результат

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine(result);