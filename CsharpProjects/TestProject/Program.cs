int[] inventory = {1, 23, 46, 77,88};
int sum = 0;
int bin = 0;

foreach (int items in inventory) {
    sum += items ;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"The sum of the numbers is: {sum}");