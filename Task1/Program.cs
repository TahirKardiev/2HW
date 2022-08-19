double a, c; string S;
Console.WriteLine("Enter a number "); S = Console.ReadLine ();
a = double.Parse (S);
Console.WriteLine("Enter numbers power"); S = Console.ReadLine ();
c = double.Parse (S);
Console.WriteLine(Math.Pow(a, c));
