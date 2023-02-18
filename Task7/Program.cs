
using Task7;

List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 20 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 20 },
    new Person { Name = "Dave", Age = 30 },
    new Person { Name = "Eve", Age = 20 }
};

var groupByAge = from p in people
    group p by p.Age 
    into g
    select new 
    {
        Age = g.Key,
     
    };
    
    
foreach (var i in groupByAge)
{
    
    Console.WriteLine(i);
}
