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

string role = "teacher";

string result3 = role switch {
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" => "Ограниченный доступ"
};
Console.WriteLine(result3);

int age = 20;
bool hasTicket = true;
switch (age){
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

int level = 2;

switch (level) {
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

Console.WriteLine("Самостоятельное задание");
int score4 = 17;
string result4 = score4 switch {
    < 0 => "Ошибка",
    >= 0 and <= 6 => "Ребенок",
    >= 7 and <= 17 => "Подросток",
    >= 18 and <= 64 => "Взрослый",
    >= 35 => "Пенсионер"
};
Console.WriteLine(result4);

Console.WriteLine("Самостоятельное задание 2");
int day = 5;
switch (day) {
    case 6 or 7: Console.WriteLine("Выходной");break;
    default: Console.WriteLine("Будни");break;
}

Console.WriteLine("Индивидуальное задание");
Console.WriteLine("Вариант 7");

int score5 = 1000;

string result5 = score5 switch {
    < 0 => "Ошибка",
    >= 0 and <= 999 => "Новичок",
    >= 1000 and <= 4999 => "Опытный",
    >= 5000 and <= 9999 => "Продвинутый",
    >= 10000 => "Мастер"
};
Console.WriteLine(result5);
