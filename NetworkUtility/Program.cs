// See https://aka.ms/new-console-template for more information
using NetworkUtility;

Console.WriteLine("Hello, World!");

static void Main(string[] args)
{
    InLineConstructor ILC = new InLineConstructor(1, 2);

    var result = ILC.AddConstructorParams();
    Console.WriteLine("Result: {0}", result);
}