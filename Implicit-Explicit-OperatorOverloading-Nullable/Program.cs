#region task2
using Implicit_Explicit_OperatorOverloading_Nullable.Models;

Celci celci = new(10);
Kelvin kelvin = celci;
Console.WriteLine(kelvin.kelvin);
#endregion
#region task3
Employee employee = new();

Employee.EmployeeInfo();

Console.WriteLine(employee.GetDataandSalary(new DateTime(1995, 09, 23), new DateTime(2000, 12, 11), 2000));

#endregion