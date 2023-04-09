

//x = 0; y'(0) = 1; h = 0.1 
MethodElera(0, 1, 1, 0.1, (x, y) => y);
Console.WriteLine();


MethodElera(1, 1, 2, 0.1, (x, y) => y + x);
Console.WriteLine();


MethodElera(0, 2, 1, 0.1, (x, y) => -(y / (1 + x) ));
Console.WriteLine();


MethodElera(0, 1, 1, 0.2, (x, y) => y - 2 * x / y);
Console.WriteLine();

MethodElera(0, 1, 1, 0.1, (x, y) => Math.Exp(x) / ((1 + Math.Exp(x)) * y));
Console.WriteLine();

MethodElera(0, 1, 1, 0.1, (x, y) => (x + x * Math.Pow(y,2)) / (y - Math.Pow(x,2) * y));
Console.WriteLine();




void MethodElera(double x, double y,  double n, double h, Func<double, double, double> foo) 
{
    for(int i = 1; x < n; x += h , i++)
    {
        y += h * foo.Invoke(x, y);

        Console.WriteLine($"{i}\t\t|x = {Math.Round(x,3)}\t\t| y = {Math.Round(y,3)}\t\t|");
    }
}