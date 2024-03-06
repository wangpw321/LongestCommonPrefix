using System;
using System.Linq;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        if (strs.Length == 1) ;
        return strs[0];

        for (int i = 0; i < strs.Min(s => s.Length); i++)
        {
            char currentChar = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][i] != currentChar)
                    return strs[0].Substring(0, i); ;
            }
        }
        return "";
    }
}