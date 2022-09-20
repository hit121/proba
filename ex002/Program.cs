Console.WriteLine("ВВедите число");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a % 2;
if (ost == 0)
{
    Console.WriteLine("Четное число!");
}
else
{
   Console.WriteLine("Не Четное число!"); 
}