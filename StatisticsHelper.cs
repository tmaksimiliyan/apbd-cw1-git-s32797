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

    public static int CalculateMax(int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }

    public static int CalculateMin(int[] values)
    {
        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
            
        }
        return min;
    }
}