Console.WriteLine("Enter length - ");

bool isNumber = int.TryParse(Console.ReadLine(), out int lengthConsole);
if (!isNumber || lengthConsole <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] array = FillArray(lengthConsole);
PrintArray(array);

int EvenNumberInArray = GetEvenNumberInArray(array);

Console.WriteLine($"sum Even Number - {EvenNumberInArray}");

int GetEvenNumberInArray(int[] array)
{
    int n= 0;
    int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        n = array[i] % 2;
        if(n==0)
        {
          m = m+1;
        
        }
        
    }

    return m;
}

void PrintArray(int[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Ошибка");
        return;
    }
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }

    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100,1000);
    }
    return array;
}