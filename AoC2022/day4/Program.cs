var totalScore = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    var assignements = line.Split(',');

    var first = assignements[0].Split('-');
    var firstLowerBound = Convert.ToInt32(first[0]);
    var firstUpperBound = Convert.ToInt32(first[1]);

    var second = assignements[1].Split('-');
    var secondLowerBound = Convert.ToInt32(second[0]);
    var secondUpperBound = Convert.ToInt32(second[1]);

    // Part 1
    if (DoesSetContainSet(firstLowerBound, firstUpperBound, secondLowerBound, secondUpperBound)) totalScore++;

    // Part 2 
    //if (DoSetsIntersect(firstLowerBound, firstUpperBound, secondLowerBound, secondUpperBound)) totalScore++;
}

Console.WriteLine(totalScore);


bool DoesSetContainSet(int a1, int b1, int a2, int b2)
{
    return (a1 >= a2 && b1 <= b2) || (b1 >= b2 && a1 <= a2);
}

bool DoSetsIntersect(int a1, int b1, int a2, int b2)
{
    return !(a1 > b2 || b1 < a2);
}

