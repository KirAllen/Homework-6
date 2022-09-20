// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Input Length");
int m = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[m]; 
Console.WriteLine(CountNum(array)); 

int CountNum(int[] array)
{
    int count = 0; 
    for(int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Input Number");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
        if(array[i] > 0)
        {
            count = count + 1; 
        }
    }
    return count; 
}

