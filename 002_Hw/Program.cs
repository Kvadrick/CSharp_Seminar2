int a = Convert.ToInt32(Console.ReadLine());

if(a < 1000)
{
    if(a < 100) Console.WriteLine("Третьей цифры нет");
    else Console.WriteLine(a % 10);
} 

if(a > 1000)
{
    do
    {
        a = a / 10;
        
    }
    while (a >= 1000);
    Console.WriteLine(a % 10);
}
