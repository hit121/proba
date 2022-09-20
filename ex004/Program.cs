// задача 4

Console.Clear();

Console.Write("Enter number a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter number b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Enter number c: ");
int c = int.Parse(Console.ReadLine());

int numberMax = int.MinValue;
numberMax = numberMax > a ? numberMax : a;
if (numberMax > a) numberMax = numberMax;
else numberMax = a;
numberMax = numberMax > b ? numberMax : b;
numberMax = numberMax > c ? numberMax : c;

Console.WriteLine(("Maximum number is ") + (numberMax));