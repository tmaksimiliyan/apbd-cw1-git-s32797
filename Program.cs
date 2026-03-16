using apbd_cw1_git_s32797;

Console.WriteLine("Podaj liczby oddzielone spacjami:");
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
    numbers[i] = double.Parse(parts[i]);
}

if (valid)
{
    double average = StatisticsHelper.CalculateAverage(numbers);
    Console.WriteLine($"Średnia: {average}");
}

