// заполнить строку числами от a до b, a <= b

// итеративный подход
string NumbersFor(int a, int b){
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}


// рекурсия

string NumbersRec(int a, int b){
    if(a<= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.Clear();
Console.WriteLine($"{NumbersFor(1, 10)}");
Console.WriteLine($"{NumbersRec(1, 10)}");