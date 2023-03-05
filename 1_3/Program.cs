void pow_numbers(int number)
{
  int index = 1;
  while(index <= number)
  {
    Console.Write(Math.Pow(index, 2) + " ");
    index = index + 1; 
  }
}
pow_numbers(int.Parse(Console.ReadLine()));
