using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your target ");
        int UserTarget = int.Parse(Console.ReadLine());
        int start = 0;
        while(start <= UserTarget)
        {
            Console.WriteLine(start);
            start += 2; 
        }
    }
}
