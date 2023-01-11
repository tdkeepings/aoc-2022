var totalScore = 0;

var cargo = new Dictionary<int, string>();


var cargoLines = new List<string>();
var instructions = new List<string>();

var isCargoRead = true;
foreach (var line in File.ReadLines("input.txt"))
{
    if (string.IsNullOrEmpty(line)) { isCargoRead = false; }

    if (isCargoRead)
    {
        cargoLines.Add(line);    
    }    
    else
    {
        if (string.IsNullOrEmpty(line)) { continue; }
        instructions.Add(line);
    }

}

// Open up the dictionary...
var cargoNumbers = cargoLines.Last().Trim().Replace("   "," ").Split(' ');
foreach(var number in cargoNumbers)
{
    cargo.Add(Convert.ToInt32(number), "");
}

// Populate the dictionary...
cargoLines.Reverse();
foreach(var line in cargoLines)
{
    if (line.Any(c => char.IsLetter(c)))
    {
        var indexToHit = 1;
        var n = 1;

        for (var i = 0; i < 9; i++)
        {
            var cargoChar = line[n];
            if (cargoChar != ' ')
            {
                cargo[indexToHit] += cargoChar;
            }
            indexToHit++;
            n += 4;
        }
    }
}

// Do the work
foreach(var line in instructions)
{
    var parts = line.Split(' ');
    var amount = Convert.ToInt32(parts[1]);
    var from = Convert.ToInt32(parts[3]);
    var to = Convert.ToInt32(parts[5]);

    var stack = cargo[from];
    var cargoToMove = stack.Substring(stack.Length - amount, amount);
    var newStack = stack.Substring(0, stack.Length - amount);

    // Part 1 
    //char[] array = cargoToMove.ToCharArray();
    //Array.Reverse(array);
    //var reversedCargo = new string(array);

    //cargo[from] = newStack;
    //cargo[to] += reversedCargo;

    // Part 2 
    cargo[from] = newStack;
    cargo[to] += cargoToMove;
}

for (int i = 1; i < 10; i++)
{
    Console.Write(cargo[i].Last());
}