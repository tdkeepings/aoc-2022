using System.Diagnostics;

var totalScore = 0;

foreach (var line in File.ReadLines("input.txt"))
{
    // Part 2 / Solution 2. 
    var bufferSize = 14; // Part 1 would be bufferSize = 4 and still works.
    for (int i = 0; i < line.Length; i++)
    {
        var buffer = line.Substring(i, bufferSize);

        // Scan buffer for duplicates
        var dupFound = false;
        for (int j = 0; j < bufferSize - 1; j++)
        {
            if (dupFound) break;
            for (int k = j + 1; k < bufferSize; k++)
            {
                if (dupFound) break;
                if (buffer[j] == buffer[k]) dupFound = true;
            }
        }

        if (!dupFound)
        {
            Console.WriteLine(i + bufferSize); // Because the 6th index is the 7th character
            break;
        }
    }

    // Part 1 / Solution 1 
    //for (int i = 0; i < line.Length; i++)
    //{
    //    // Shift first 
    //    buffer[3] = buffer[2];
    //    buffer[2] = buffer[1];
    //    buffer[1] = buffer[0];
    //    buffer[0] = line[i];

    //    if (i > 3)
    //    {
    //        // Scan buffer for duplicates
    //        var dupFound = false;
    //        for (int j = 0; j < 3; j++)
    //        {
    //            if (dupFound) break;
    //            for (int k = j + 1; k < 4; k++)
    //            {
    //                if (dupFound) break;
    //                if (buffer[j] == buffer[k]) dupFound = true;
    //            }
    //        }

    //        if (!dupFound)
    //        {
    //            Console.WriteLine(i + 1); // Because the 6th index is the 7th character
    //            break;
    //        }
    //    }
    //}
}