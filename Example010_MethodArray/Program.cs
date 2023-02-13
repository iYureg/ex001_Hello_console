int[] array = { 1, 12, 31, 4, 15, 16, 4, 17, 18, 9, 4 };

int n = array.Length;
int find = 4;

int index = 0;

while( index < n )
{
    if( array[index] == find )
    {
        Console.WriteLine(index);
        break; // завершить работу
    }

    index++;  //index = index + 1;
}



