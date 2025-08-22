public class TestCharacterDiff
{
  public static bool Have1DifferentCharacter(string str1, string str2)
  {
    if (str1.Length != str2.Length) return false;

    int diffCount = 0;

    for (int i = 0; i < str1.Length; i++)
    {
      if (str1[i] != str2[i])
      {
        diffCount++;
        if (diffCount > 1) return false;
      }
    }

    return diffCount == 1;
  }

  public static bool Have1CharacterMoreOrLess(string str1, string str2)
  {
    if (Math.Abs(str1.Length - str2.Length) != 1) return false;

    string longer = str1.Length > str2.Length ? str1 : str2;
    string shorter = str1.Length < str2.Length ? str1 : str2;

    int diffCount = 0;
    int shorterIndex = 0;

    for (int longerIndex = 0; longerIndex < longer.Length; longerIndex++)
    {
      if (shorterIndex < shorter.Length && longer[longerIndex] == shorter[shorterIndex])
      {
        shorterIndex++;
      }
      else
      {
        diffCount++;
        if (diffCount > 1) return false;
      }
    }

    return true;
  }

  public static void RunTest()
  {
    Console.WriteLine(Have1DifferentCharacter("abc", "abd")); // true
    Console.WriteLine(Have1DifferentCharacter("abc", "ab")); // false
    Console.WriteLine(Have1CharacterMoreOrLess("abc", "ab")); // true
    Console.WriteLine(Have1CharacterMoreOrLess("abc", "ac")); // true
    Console.WriteLine(Have1CharacterMoreOrLess("abc", "bc")); // true
    Console.WriteLine(Have1CharacterMoreOrLess("abc", "abcd")); // true
    Console.WriteLine(Have1CharacterMoreOrLess("abc", "xyz")); // false
  }
}