void FillArray( int[] collection )

{
    int length = collection.Length;
    int index = 0;
    while( index < length )
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray( int[] col )
{
    int count = col.Length;
    int position = 0;
    while ( position < count )
    {
        Console.WriteLine( col[position] );
        position++;
    }
}

int IndexOf( int[] collecton, int find )
{
    int count = collecton.Length;
    int index = 0;
    int position = -1; // такой программистский прием - если нет такого элемента покажет -1

    while ( index < count )
    {
        if( collecton[index] == find )
        {
            position = index;
            break;
        }

        index++;
    }
    return position;
}

int[] array = new int[10];
 
FillArray( array );
PrintArray( array );

Console.WriteLine("_______________");

int pos = IndexOf(array, 4);
Console.WriteLine(pos);