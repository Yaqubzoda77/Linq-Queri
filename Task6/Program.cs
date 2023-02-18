


using Task6;

List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Alice", Department = "Sales", Salary = 50000
    },
    new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
    new Employee { Name = "Charlie", Department = "Sales", Salary = 
        55000 },
    new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
    new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};

var Employee = from e in employees
    group e by e.Department
    into g
    orderby g.Average(e => e.Salary)
    select new 
    {
        Depatment = g.Key,
        AveregeSalary = g.Average(e => e.Salary)
    };
foreach (var d in Employee)
{
    Console.WriteLine(d);
}
   
