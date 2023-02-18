
string[] names = { "Alicea", "Anny", "Amy", "Dave", "Alex" };
var StartWithA = names.Where(x => x.StartsWith("A")).Where(x => x.EndsWith("a"));
foreach (var s in StartWithA)
{
    Console.WriteLine(s);
}