
Console.WriteLine("çarpım tablosuna hoşgeldiniz");
Thread.Sleep(2000);
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"  {i} x  {j}  =  {i * j }" );
    }
    Console.WriteLine();
}