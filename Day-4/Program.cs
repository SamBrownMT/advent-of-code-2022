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
        var intSectionArray = sectionArray.Select(section => int.Parse(section)).ToArray();
        return intSectionArray;

    }
}