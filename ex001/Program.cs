int numberOne = 0;
int numberTwo = 0;
while (true){
    try{
        Console.Write("Введите первое число: ");
        numberOne = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите второе число: ");
        numberTwo = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        Console.Write("Введите некорректное значение,введите целое число: ");  
    }
}

if (numberOne > numberTwo) 
    Console.Write("Число {0} больше числа {1}", numberOne, numberTwo);
else if (numberOne == numberTwo) Console.Write("Число {0} больше числа {1}", numberOne, numberTwo);
else Console.Write("Число {1} больше числа {0}", numberOne, numberTwo);
