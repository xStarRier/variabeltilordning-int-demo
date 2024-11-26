// See https://aka.ms/new-console-template for more information
int sum;

int NumberFunc()
{

    Console.WriteLine("Insert Number Please");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert Number Please");
    int num2 = Convert.ToInt32(Console.ReadLine());

    sum = num1 + num2;

    return sum;

}
void Run()
{
    NumberFunc();
    Console.WriteLine($"The summary is: {sum}!");
    Console.WriteLine($"Thank you for typing a number:)");
}
Run();
