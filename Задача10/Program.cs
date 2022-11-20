Console.Write("Введите 3-х значное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb > 100 && numb < 999 )
{
    int numb2 = numb/10 - numb/100*10;
    Console.WriteLine("Вторая цифра числа" + " " + numb2 );
}
else
{
    Console.WriteLine("Неверное число. Попробуйте снова");
    
}
