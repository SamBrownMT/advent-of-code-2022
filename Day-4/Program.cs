﻿// See https://aka.ms/new-console-template for more information

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

    public static bool Overlaps(int[][] elves)
    {
        if (elves[0][0] <= elves[1][0] && elves[1][0] <= elves[0][1])
        {
            return true;
        }
        
        if (elves[1][0] <= elves[0][0] && elves[0][0] <= elves[1][1])
        {
            return true;
        }

        return false;
    }
    
    public static int FullyContainedSum(string[] elves)
    {
        var containedSum = 0;
        foreach (var pair in elves)
        {
            var formattedPair = ElfFormatter(pair);
            if (IsFullyContained(formattedPair))
            {
                containedSum += 1;
            }
        }

        return containedSum;
    }

    public static int OverlapSum(string[] elves)
    {
        var overlapSum = 0;
        foreach (var pair in elves)
        {
            var formattedPair = ElfFormatter(pair);
            if (Overlaps(formattedPair))
            {
                overlapSum += 1;
            }
        }

        return overlapSum;
    }
}