using System.Threading.Channels;

int[] numbers = { 1, 5, 8, 12, 15, 20 };

var findsumOfOdds = numbers.Where(x => x % 2 != 0);
var f = findsumOfOdds.Sum();
Console.WriteLine(f);