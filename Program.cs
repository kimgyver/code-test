// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;


// TestSocialMedia.RunTest();

// LogReader.RunTest();
// return;

// TestCharacterDiff.RunTest();

// Test3.RunTest();
Test2.RunTest();
return;


TestBalanceChecker.RunTest();
return;

TestReports.RunTest();
Console.WriteLine("=============================");
return;

// Test4.RunTest();
TestMergeIntervals.RunTest();
TestTopKFrequent.RunTest();
return;


Test1.RunTest();
Console.WriteLine("=============================");

Test4.RunTest();
Console.WriteLine("=============================");



// var result13 = GcdOfStrings("ABCABC", "ABCD");
// System.Console.WriteLine(result13);

// System.Console.WriteLine(RemoveStars("leet**cod*e"));

// AsteroidCollision([-2, -1, 1, 2]);

// System.Console.WriteLine("GetCharacterCount()" + GetCharacterCount("Hellow my friend"));

// System.Console.WriteLine(DecodeString("3[a]2[bc]"));

// System.Console.WriteLine(DecodeString("3[a2[c]]"));

// // System.Console.WriteLine(RemoveNonAlphanumeric("A man, a plan, a canal: Panama"));
// var alphaNum = RemoveNonAlphanumeric("A man, a plan, a canal: Panama");
// var lowered = alphaNum.ToLower();
// var firstHalf = lowered.Substring(0, lowered.Length / 2);
// var lastHalf = lowered.Substring(lowered.Length - lowered.Length / 2, lowered.Length / 2);
// System.Console.WriteLine(firstHalf + " " + lastHalf);
// System.Console.WriteLine(Reverse(lastHalf));
// System.Console.WriteLine(Reverse(lastHalf) == (firstHalf));
// // 123456789012345678901
// // amanaplana canalpanama
// return;


int dividend = Convert.ToInt32("10");
int divisor = Convert.ToInt32("3");

if ((divisor != 0) && (dividend / divisor) is var result)
{
  Console.WriteLine("Quotient: {0}", result);
}
else
{
  Console.WriteLine("Attempted division by 0 ends up here.");
}


Console.WriteLine("Hello, LINQ!");

// Data source
string[] names = { "Bill", "Steve", "James", "Mohan" };

// LINQ Query 
var myLinqQuery = from name in names
                  where name.Contains('a')
                  select "Mr " + name;

// Query execution
foreach (var name in myLinqQuery)
  Console.Write(name + " ");
