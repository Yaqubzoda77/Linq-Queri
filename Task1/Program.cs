int[] numbers = { 1, 5, 8, 12, 15, 20 };
var FindGreaterFrom = numbers.Where(x => x > 10)  ;
foreach (var s in FindGreaterFrom)
{
    Console.WriteLine(s);
}