void pow_numbers(int number)
{
  if(number > 0)
  {
    int index = 1;
    while(index <= number)
    {
    Console.Write(Math.Pow(index, 3) + " ");
    index = index + 1; 
    }
  }
  else if (number < 0)
  {
    int indexx = -1;
    while(indexx >= number)
    {
      Console.Write(Math.Pow(indexx, 3) + " ");
      indexx = indexx - 1; 
    }
  }
  else Console.WriteLine("Error");
}
pow_numbers(int.Parse(Console.ReadLine()));