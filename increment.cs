using System;
namespace Weekend
{

class Increments
{
public static void Main(string[] args)
{
int x=Console.Convert(args[0]);
Increment(ref x);
Console.WriteLine("the value is {0}",x);
}
static void Increment(ref int a)
{
a+=5;
}
}
}