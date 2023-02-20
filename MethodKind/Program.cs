// 1. Ничего не принимают и ничего не возвращают - `void`
    
void Method1()
{
    	Console.WriteLine("text ... ");
}
Console.WriteLine("-------Method1-------");
Method1(); // вызываем метод


// Принимают аргументы и ничего не возвращают - void

void Method2(string msg)
{
	Console.WriteLine(msg);
}
void Method21(string msg, int count)
{
	int i = 0;
	while(i < count)
	{
		Console.WriteLine(msg);
		i++; // ++ инкримент ( -- декримент )
	}
}

Console.WriteLine("-------Method2-------");
Method2("text ... ");

Console.WriteLine("-------Method21------");
Method21("text ... ", 4);

Console.WriteLine("-------Method21------");
Method21(count:4, msg:"text ... ");

// Могут принимать аргументы и что-то возвращают

int Method3()
{
	return DateTime.Now.Year;
}
Console.WriteLine("-------Method3-------");
int year = Method3();
Console.WriteLine(year);

// Принимают аргументы и что-то возвращают

string Method4(int count, string c)
{
	string result = String.Empty; // или просто = "";  //пустая строка

	for(int i = 0; i < count; i++)
	{
		result = result + c;
	}

	return result;
}
Console.WriteLine("-------Method4-------");
string res = Method4(10, "qwerty");
Console.WriteLine(res);