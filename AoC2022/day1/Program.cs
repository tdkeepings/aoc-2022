
var elfCalories = new List<int>();
var currentCalorie = 0;
foreach (var line in File.ReadLines("input.txt")){
    
    if (string.IsNullOrEmpty(line))
    {
        elfCalories.Add(currentCalorie);
        currentCalorie = 0;
        continue;
    }

    currentCalorie += Convert.ToInt32(line);
}

// Console.WriteLine(elfCalories.MaxBy(x => x)); // Part 1
Console.WriteLine(elfCalories.OrderByDescending(x => x).Take(3).Sum()); // Part 2