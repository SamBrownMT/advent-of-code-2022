// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace Day_4;

public class Cleanup
{
    public static int[][] ElfFormatter(string elves)
    {
        var sectionArray = elves.Split(",");
        var sectionMArray = sectionArray.Select(ElfSectionFormatter).ToArray();
        return sectionMArray;
    }

    private static int[] ElfSectionFormatter(string elfSection)
    {
        var sectionArray = elfSection.Split("-");
        var intSectionArray = sectionArray.Select(int.Parse).ToArray();
        return intSectionArray;

    }

    public static bool IsFullyContained(int[][] elves)
    {
        if (elves[0][0] <= elves[1][0] && elves[0][1] >= elves[1][1])
        {
            return true;
        }
        
        if (elves[0][0] >= elves[1][0] && elves[0][1] <= elves[1][1])
        {
            return true;
        }
        
        return false;
    }
}