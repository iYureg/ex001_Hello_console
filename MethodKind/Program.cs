//1. Ничего не принимают и ничего не возвращают - `void`
 Console.WriteLine("---------------Method1--------------");   
void Method1()
{
    Console.WriteLine("text ... ");
}
    
    Method1(); // вызываем метод

//2. Принимают аргументы и ничего не возвращают - `void`

Console.WriteLine("---------------Method2--------------");
void Method2(string msg)
    {
    	Console.WriteLine(msg);
    }
    
    Method2("text ... ");
    
    void Method21(string msg, int count)
    {
    	int i = 0;
    	while(i < count)
    	{
    		Console.WriteLine(msg);
    		i++; // ++ инкримент ( -- декримент )
    	}
    }
Console.WriteLine("---------------Method21--------------");
Method21("text ... ", 4);
Console.WriteLine("---------------Method21--------------");
Method21(count:4, msg:"text ... ");


// 3. Могут принимать аргументы и что-то возвращают 
Console.WriteLine("---------------Method3--------------");

int Method3()
{
    return DateTime.Now.Year;
}
    
int year = Method3();
Console.WriteLine(year);

    
// 4. Принимают аргументы и что-то возвращают

Console.WriteLine("--------------Method4--------------");

string Method4(int count, string c)
{
	string result = String.Empty; // или просто = "";  //пустая строка

	for(int i = 0; i < count; i++)
	{
		result = result + c;
	}

	return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);