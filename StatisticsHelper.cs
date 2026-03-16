namespace apbd_cw1_git_s32797;

public class StatisticsHelper
{
    public static double CalculateAverage(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }

    public static double CalculateAverage(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return (double) sum / values.Length;
    }
}