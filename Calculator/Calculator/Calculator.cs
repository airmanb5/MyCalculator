public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public double Divide(double divisor, double divident)
    {
        double result = divisor / divident;

        return result;
    }

    public bool isPrime(int v)
    {
        if (v <= 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i < v; i++)
            {
                if (v % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

