// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter a number");
var UserNumber = (Console.ReadLine());
var Number = int.Parse(UserNumber);
if (Number < 10)
{
    Console.WriteLine("NoK");
}
else
{
    Console.WriteLine("OK");
}
Console.ReadKey();
