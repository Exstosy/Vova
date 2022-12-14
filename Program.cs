Console.Clear();
Console.WriteLine("Введите число b1");
 float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1 ");
 float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
 float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
 
  float k2 = Convert.ToInt32(Console.ReadLine());
   float x = (-b2 + b1)/(-k1 + k2);
   float y = (k2 * x+ b2);
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
