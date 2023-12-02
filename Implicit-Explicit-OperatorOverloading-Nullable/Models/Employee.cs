

namespace Implicit_Explicit_OperatorOverloading_Nullable.Models
{
    
    
        public class Employee
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; set; }
            public int Salary { get; set; }

            public Employee(string name, string surname, DateTime birthday, int salary)
            {
                Name = name;
                Surname = surname;
                Birthday = birthday;
                Salary = salary;
            }

            public Employee()
            {
            }

            public static Employee[] EmployeeInfo()
            {
                Employee employee = new Employee("islam", "Adisirinli", new DateTime(2004, 12, 11), 3000);
                Employee employee2 = new Employee("Fidan", "Suleymanli", new DateTime(1999, 05, 21), 2500);
                Employee employee3 = new Employee("Fuad", "Isgenderov", new DateTime(1993, 05, 02), 500);

                Employee[] empinfo = { employee, employee2, employee3 };
                return empinfo;

            }

            public int GetDataandSalary(DateTime a, DateTime b, int salary)
            {
                int next = 0;
                Employee[] employemethod = EmployeeInfo();
                foreach (Employee employee in employemethod)
                {
                    if (employee.Birthday >= a && employee.Birthday <= b && employee.Salary > salary)
                    {
                        next++;
                    }
                }
                return next;
            }


        }
    
}
