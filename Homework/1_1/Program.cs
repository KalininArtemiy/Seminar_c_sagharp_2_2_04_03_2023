void is_palindrom(string number)
{
  int len = number.Length;
  if (len == 5)
  {
    if (number[0] == number[4] && number[1] == number[3])
    {
      Console.WriteLine("Is Palindrom");
    }
    else  Console.WriteLine("Not Palindrom");
  }
  else Console.WriteLine("Has no five symbols");
}
is_palindrom(Console.ReadLine());