int number = new Random().Next(10,100);
Console.WriteLine ($"Наше случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 10;

if(digit1>digit2)
{
    Console.WriteLine (digit1 + " наибольшая цифра");
}
else 
{
    Console.WriteLine (digit2 + " наибольшая цифра");
}