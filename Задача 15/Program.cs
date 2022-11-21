Console.Write("Введите число обозначающее день недели:");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb<5&&numb>0)
{
    
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
} 




/*  
if(numb == 1 || numb == 2 || numb == 3 || numb == 4 || numb == 5 )
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}  */ 

 

/* int [] arry = { 1, 2, 3, 4, 5 };
int index =0 ;
int long1 = arry.Length; 

if(numb>5)
{
   Console.WriteLine("Не выходной"); 
}
while(index<long1)
{
    if(arry[index]==numb)
    {
        Console.WriteLine("Выходной");
        break; 
                
    }
    index++; 
}
*/