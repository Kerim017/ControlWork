string [] array = {"hello","2","world",":-)"};

void SortingElementsOfArray( string [] arrayForSorting)
{
    for (int i = 0; i < array.Length; i++)
    {
        int m = 3;
        if (array[i].Length <= m)
        {
            Console.WriteLine($"{array[i]}");
        }    
    }
}

SortingElementsOfArray(array);