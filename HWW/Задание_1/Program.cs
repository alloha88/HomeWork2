// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next (100, 999);
Console.WriteLine("Сгенерировано случайное число" + number);

int showNumber(int number1)
{
    int firstStep = number1/ 10;
    int secondStep = firstStep % 10;

    return secondStep;
}


Console.WriteLine("Вторая цифра числа" + showNumber(number));