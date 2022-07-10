// Напишите программу которая выводит третью цифру заданного числа или сообщает что третьей цифры нет

Console.WriteLine("Введите число");
string numbers = Console.ReadLine();

string thirdNumber() {

    if (numbers.Length <= 2){
        return "В числе нет третьей цифры!";
    }
    else {
        return "Третья цифра в числе " + numbers+ " "+ numbers[2];
    }
}


Console.WriteLine(thirdNumber());
