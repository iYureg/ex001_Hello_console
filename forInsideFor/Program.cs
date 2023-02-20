// выводим таблицу умножения используя цикл в цикле

// for (int i = 2; i <= 10; i++){
//     for (int j = 2; j <= 10; j++){

//     Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// ========= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить на большие "К",
// а большие "С" заменить на маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде ,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = "";

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";

    }

    return result;
}

Console.Clear();
string newText = Replace(text, oldValue: ' ', newValue: '_');
Console.WriteLine(newText);

newText = Replace(newText, oldValue: 'к', newValue: 'К');
Console.WriteLine(newText);