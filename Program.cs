int dayNumber = 5;
switch (dayNumber){
    case 6 or 7 or 5: Console.WriteLine("Выходной");break;
    default: Console.WriteLine("Будний");break;
}

int score = 100;

switch (score){
    case >= 0 and < 39:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and 59:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and 79:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;

}

int score1 = 78;

string result = score1 switch {
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};
Console.WriteLine(result);

int temp = 37;

string result2 = temp switch {
    < 0 => "Мороз",
    >= 0 and <= 14 => "Прохладно",
    >= 15 and <= 24 => "Тепло",
    >= 25 and <= 35 => "Жарко",
    >= 35 => "Очень жарко"
};
Console.WriteLine(result2);