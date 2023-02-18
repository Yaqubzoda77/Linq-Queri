int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };


var  top3highest = (from n in numbers 
        orderby n descending 
        select n).Take(3);

    foreach (var f in  top3highest)
    {
        Console.WriteLine(f);
    }
