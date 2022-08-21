double n, sum, dig ; string S; Console.WriteLine("Enter a number "); S = Console.ReadLine ();
n = double.Parse (S);
sum = 0;
dig = 0;
while(n > 0)
{
    if (n > 9)
    {
    dig = n % 10;
    }
    else 
    {
        dig = n;
    }
sum = sum + dig;
n = (n-dig)/10;
}

Console.WriteLine ($"Сумма цифр равна:{sum}");
