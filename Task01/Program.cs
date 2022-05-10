string [] array = {"hello","2","world",":-)"};

void SortingElementsOfArray( string [] arrayForSorting)
{
    for (int i = 0; i < array.Length; i++)
    {
        //int m = 3;
        if (array[i].Length <= 3)
        {
            Console.WriteLine($"{array[i]}");
        }    
    }
}

SortingElementsOfArray(array);