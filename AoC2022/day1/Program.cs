var elfCalories = new List<int>();
var currentCalorie = 0;
foreach (var line in File.ReadLines("input.txt"))
{
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

// ----------------------------
// Solution 2 part 1 - memory efficient
// ----------------------------
// var highest = 0;
// var currentCalorie = 0;
// foreach (var line in File.ReadLines("input.txt")){
//     
//     if (string.IsNullOrEmpty(line))
//     {
//         if (currentCalorie > highest)
//         {
//             highest = currentCalorie;
//         } 
//         currentCalorie = 0;
//         continue;
//     }
//
//     currentCalorie += Convert.ToInt32(line);
// }
//
// Console.WriteLine(highest);


// ----------------------------
// Solution 2 part 2 - memory efficient
// ----------------------------
// var topN = 3;
// var highest = new int[topN];
// var currentCalorie = 0;
// foreach (var line in File.ReadLines("input.txt")){
//
//     if (string.IsNullOrEmpty(line))
//     {
//         for (int i = 0; i < topN; i++)
//         {
//             if (currentCalorie > highest[i])
//             {
//                 highest[i] = currentCalorie;
//                 break;                
//             }
//         }
//         
//         currentCalorie = 0;
//         continue;
//     }
//     currentCalorie += Convert.ToInt32(line);
// }
//
// Console.WriteLine(highest.Sum());