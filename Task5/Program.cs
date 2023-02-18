
string[] words = { "apple", "banana", "cherry", "date", "elderberry" };
var SortArraayByLength = words.OrderByDescending(x => x.Length);
foreach (var d in SortArraayByLength)
{
    Console.WriteLine(d);
}