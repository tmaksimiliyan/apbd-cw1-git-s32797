using apbd_cw1_git_s32797;

Console.WriteLine("Podaj liczby oddzielone spacjami:");
string input = Console.ReadLine() ?? "";

string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
double[] numbers = new  double[parts.Length];

for (int i = 0; i < parts.Length; i++)
{
    numbers[i] = double.Parse(parts[i]);
}

double average = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine($"Średnia: {average}");
