void Quartes(int z)
{
  if ( z < 0 || z == 0 || z > 4)
    Console.WriteLine ("Error");
  else if (z == 1)
    Console.WriteLine ("x > 0, y > 0");
  else if (z == 2)
    Console.WriteLine ("x < 0, y > 0");
  else if (z == 3)
    Console.WriteLine ("x < 0, y < 0");
  else if (z == 4)
    Console.WriteLine ("x < 0 && y < 0");
} 
Quartes(int.Parse(Console.ReadLine()!));
