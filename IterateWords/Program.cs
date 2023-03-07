// перебор всех возможных слов

// через for

char[] simbols = { 'а', 'и', 'с', 'в' };

int count = simbols.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                Console.WriteLine($"{n++,-5}{simbols[i]}{simbols[j]}{simbols[k]}{simbols[l]}");
            }
        }    
    }
}

void FindWords(string alphabet, char[] word, int length = 0){
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
Console.WriteLine();
FindWords("аисв", new char[5]); // FindWords("аисв", new char[6]); // 7, 8, ...