Console.WriteLine("Enter length - ");

bool isNumber = int.TryParse(Console.ReadLine(), out int lengthConsole);
if (!isNumber || lengthConsole <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

double[] array = FillArray(lengthConsole);
PrintArray(array);

double EvenNumberInArray = GetDifferenceMaxMinInArray(array);

Console.WriteLine($"Difference Max to Min InArray - {EvenNumberInArray}");

double GetDifferenceMaxMinInArray(double[] array)
{
    double maxValue= array[0];
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(maxValue < array[i])
        {
          maxValue = array[i];
        }
        if(minValue > array[i])
        {
            minValue = array[i];
        }
    }
    double result = maxValue - minValue;
    result = Math.Round(result,2);
    return result;
}

void PrintArray(double[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("Ошибка");
        return;
    }
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }

    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

double[] FillArray(int length)
{
    double[] array = new double[length];
    
    Random random = new Random();
    Random r = new Random();
    for (int i = 0; i < length; i++)
    {
       //double l =  Convert.ToDouble(Console.ReadLine());
       //array[i] = r.Next(1,100) ;
       array[i] = random.Next(1,10000) /100.0;
    }
    return array;
}