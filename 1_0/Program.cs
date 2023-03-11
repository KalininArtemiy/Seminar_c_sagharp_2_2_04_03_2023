void Quartes(int x, int y)
{
  if (x == 0 || y == 0)
    Console.WriteLine ("Error");
  else if (x > 0 && y > 0)
    Console.WriteLine ("First");
  else if (x < 0 && y > 0)
    Console.WriteLine ("Second");
  else if (x < 0 && y < 0)
    Console.WriteLine ("Third");
  else if (x < 0 && y < 0)
    Console.WriteLine ("Fourth");
} 

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quartes(num_1, num_2);