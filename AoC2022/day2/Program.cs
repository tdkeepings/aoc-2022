var totalScore = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    var lineSplits = line.Split(' ');
    var opponentChoice = lineSplits[0];
    var myChoice = lineSplits[1];

    //var matchScore = Part1Scoring(opponentChoice, myChoice);
    var matchScore = Part2Scoring(opponentChoice, myChoice);

    totalScore += matchScore;
}

Console.WriteLine(totalScore);


int Part1Scoring(string opponentChoice, string myChoice)
{
    // Score based on what you are told to pick. 
    // Rock (AX) = 1, Paper (BY) = 2, Scissors (CZ) = 3
    var myChoiceScore = 0;
    switch (myChoice)
    {
        case "X": myChoiceScore += 1; break;
        case "Y": myChoiceScore += 2; break;
        case "Z": myChoiceScore += 3; break;
    }

    // Score on the outcome of the round. 
    // Lose = 0, Draw = 3, Win = 6
    var opponentChoiceScore = 0;
    switch (opponentChoice)
    {
        case "A":
            switch (myChoice)
            {
                case "X": opponentChoiceScore += 3; break;
                case "Y": opponentChoiceScore += 6; break;
                case "Z": opponentChoiceScore += 0; break;
            }

            break;
        case "B":
            switch (myChoice)
            {
                case "X": opponentChoiceScore += 0; break;
                case "Y": opponentChoiceScore += 3; break;
                case "Z": opponentChoiceScore += 6; break;
            }

            break;
        case "C":
            switch (myChoice)
            {
                case "X": opponentChoiceScore += 6; break;
                case "Y": opponentChoiceScore += 0; break;
                case "Z": opponentChoiceScore += 3; break;
            }

            break;
    }

    return myChoiceScore + opponentChoiceScore;
}

int Part2Scoring(string opponentChoice, string myDirective)
{
    var myChoice = GetChoiceFromDirective(opponentChoice, myDirective);
    
    return Part1Scoring(opponentChoice, myChoice);
}

string GetChoiceFromDirective(string opponentChoice, string myChoice)
{
    switch (myChoice)
    {
        case "X": // must lose
            switch (opponentChoice)
            {
                case "A": return "Z";
                case "B": return "X";
                case "C": return "Y";
            }

            break;
        case "Y": // must draw
            switch (opponentChoice)
            {
                case "A": return "X";
                case "B": return "Y";
                case "C": return "Z";
            }

            break;
        case "Z": // must win
            switch (opponentChoice)
            {
                case "A": return "Y";
                case "B": return "Z";
                case "C": return "X";
            }

            break;
    }

    return "";
}