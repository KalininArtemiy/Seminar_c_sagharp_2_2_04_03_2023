double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
  return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + +Math.Pow(z2 - z1, 2));
}
Console.WriteLine("Enter three coordinates of the first point");
int num_x_1 = int.Parse(Console.ReadLine()!);
int num_y_1 = int.Parse(Console.ReadLine()!);
int num_z_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter three coordinates of the second point");
int num_x_2 = int.Parse(Console.ReadLine()!);
int num_y_2 = int.Parse(Console.ReadLine()!);
int num_z_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Distance(num_x_1,  num_y_1, num_z_1, num_x_2, num_y_2, num_z_2));
