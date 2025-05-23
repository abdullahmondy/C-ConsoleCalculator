public class CalculatorLogic
{
    protected List<Dictionary<string, double>> history = new List<Dictionary<string, double>>();

    public double Sum(double num1, double num2)
    {
        double result = num1 + num2;
        string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Dictionary<string, double> h = new Dictionary<string, double>();

        h.Add(d, result);

        history.Add(h);

        return result;
    }

    public double Sub(double num1, double num2)
    {
        double result = num1 - num2;
        string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Dictionary<string, double> h = new Dictionary<string, double>();

        h.Add(d, result);

        history.Add(h);

        return result;
    }

    public double Multibly(double num1, double num2)
    {
        double result = num1 * num2;
        string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Dictionary<string, double> h = new Dictionary<string, double>();

        h.Add(d, result);

        history.Add(h);

        return result;
    }

    public double Divide(double num1, double num2)
    {
        double result = num1 + num2;
        string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Dictionary<string, double> h = new Dictionary<string, double>();

        h.Add(d, result);

        history.Add(h);

        return result;
    }

}
