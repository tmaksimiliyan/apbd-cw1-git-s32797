using apbd_cw1_git_s32797;

Console.WriteLine("Podaj liczby oddzielone spacjami, aby obliczyć średnią:");
string input = Console.ReadLine() ?? "";

string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
double[] numbers = new  double[parts.Length];
bool valid = true;

for (int i = 0; i < parts.Length; i++)
{
    if (!double.TryParse(parts[i], out numbers[i]))
    {
        valid = false;
        break;
    }
}

if (parts.Length == 0)
{
    Console.WriteLine("Błąd: nie podano żadnych liczb");
}else if (valid)
{
    double average = StatisticsHelper.CalculateAverage(numbers);
    Console.WriteLine($"Średnia: {average}");
}
else
{
    Console.WriteLine("Błąd: podano niepoprawne dane");
}


