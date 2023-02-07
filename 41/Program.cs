int[] Fillarray()
{
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    
    return array;
}

int SummElements(int [] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<0)
        count++;
    
    }
    return count;
}

void PrintArray(int [] array)
{
    Console.Write($"[{String.Join(",",array)}]\n");
    
}

Console.Write("Введите числа: ");
int[] m = Fillarray();


PrintArray(m);

int[] array= m;
int count= SummElements(array);
Console.WriteLine($"Количество отрицательных чисел: {count}");
