public class HourlyEmployee : Employee
{
    private float rate = 50;
    private int hours = 40;

    public override float CalculatePay()
    {
        return rate * hours;
    }
}