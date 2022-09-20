//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input b1");
float b1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input k1");
float k1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input b2");
float b2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Input k2");
float k2 = Convert.ToInt32(Console.ReadLine()); 
GetInterseptiont(b1, k1, b2, k2);

void GetInterseptiont(float b1, float k1, float b2, float k2)
{
    float x = (b2 - b1) / (k1 - k2); 
    float y = k1 * x + b1; 
    // float y2 = k2 * x + b2;
   Console.WriteLine($"({x}; {y})"); 

}


