var totalScore = 0;
var lineCounter = 0;
var lineGroup = new string[3];
foreach (var line in File.ReadLines("input.txt"))
{
    // Part 2
    lineCounter++;

    lineGroup[lineCounter - 1] = line;
    if (lineCounter % 3 == 0)
    {
        // end of the group
        var character = FindCharInAllThree(lineGroup[0], lineGroup[1], lineGroup[2]);
        totalScore += GetScoreForChar(character);
        lineCounter = 0;
    }

    // Part 1 
    //var halfway = line.Length / 2;
    //var compartmentOne = line.Substring(0, halfway);
    //var compartmentTwo = line.Substring(halfway, halfway);

    //var character = FindCharInBoth(compartmentOne, compartmentTwo);
    //var score = GetScoreForChar(character);
    //totalScore += score;
}

Console.WriteLine(totalScore);

char FindCharInBoth(string one, string two)
{
    foreach (var a in one)
    foreach (var b in two)
        if (a == b)
            return a;

    return ']';
}

// There has to be a more efficient way of doing this. 
char FindCharInAllThree(string one, string two, string three)
{
    foreach(var a in one)
        foreach(var b in two)
            if (a == b)
            foreach(var c in three)
                if (b == c)
                    return c;

    return ']';
}

// Lookup for the char scores. Could do something with ASCII values instead? 
int GetScoreForChar(char c)
{
    var scores = new Dictionary<char, int>
    {
        { 'a', 1 },
        { 'b', 2 },
        { 'c', 3 },
        { 'd', 4 },
        { 'e', 5 },
        { 'f', 6 },
        { 'g', 7 },
        { 'h', 8 },
        { 'i', 9 },
        { 'j', 10 },
        { 'k', 11 },
        { 'l', 12 },
        { 'm', 13 },
        { 'n', 14 },
        { 'o', 15 },
        { 'p', 16 },
        { 'q', 17 },
        { 'r', 18 },
        { 's', 19 },
        { 't', 20 },
        { 'u', 21 },
        { 'v', 22 },
        { 'w', 23 },
        { 'x', 24 },
        { 'y', 25 },
        { 'z', 26 },

        { 'A', 27 },
        { 'B', 28 },
        { 'C', 29 },
        { 'D', 30 },
        { 'E', 31 },
        { 'F', 32 },
        { 'G', 33 },
        { 'H', 34 },
        { 'I', 35 },
        { 'J', 36 },
        { 'K', 37 },
        { 'L', 38 },
        { 'M', 39 },
        { 'N', 40 },
        { 'O', 41 },
        { 'P', 42 },
        { 'Q', 43 },
        { 'R', 44 },
        { 'S', 45 },
        { 'T', 46 },
        { 'U', 47 },
        { 'V', 48 },
        { 'W', 49 },
        { 'X', 50 },
        { 'Y', 51 },
        { 'Z', 52 }
    };

    return scores[c];
}