using System;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new HourlyEmployee());
        employees.Add(new Employee());
        foreach (Employee employee in employees)
        {
            float pay = employee.CalculatePay();
            Console.WriteLine($"Employee Pay: {employee.CalculatePay()}");
        }
    }
}