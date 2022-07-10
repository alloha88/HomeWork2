// Напишите программу которая принимает на вход цифру обозначающую день недели и проверяет является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

string numberDay() {
    if (number >= 1 & number <= 7) {
        if (number >= 1 & number <= 5) {
            return "Сегодня не выходной!!!";
        }
        else {
            return "Сегодня выходной!";
        }
    }
    else {
        return "Введите число от 1 до 7";
    }
}


Console.WriteLine(numberDay());
