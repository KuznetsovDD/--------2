﻿Console.Write("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
 if(numb<100)
{
    Console.WriteLine("Не существует 3-й цифры");
}
else 
{
    while(numb > 999)
    {
        numb = numb /10;
    }
  
    int numb2 =numb%100%10 ; 
    Console.WriteLine("3-м числом является" + " " + numb2);  
} 
