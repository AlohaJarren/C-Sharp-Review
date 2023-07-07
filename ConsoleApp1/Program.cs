using System;

namespace Consolepp1
{
    public class Program
    {

        // ------------ FUNCTIONS ------------

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        // ------------ END OF FUNCTIONS ---------------

        static void Main(string[] args) //static: do not need to create new obj for class to call function
        {
            ////Change Color Of Console and Print Hello World
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Console.WriteLine("Hello World");

            ////Ask Question, Read User Input, Prints Hello (Name)
            //Console.Write("What is your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");


            //// 32 Bit Num Types Display
            //bool canIVote = true;
            //Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            //Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            //Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            //Console.WriteLine("Smallest Long : {0}", long.MinValue);

            //decimal decPiVal = 3.1415926535897932384626433832M;
            //decimal decBigNum = 3.00000000000000000000000000011M;
            //Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            //Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);


            //// 64 Bit Num Types
            //Console.WriteLine("Biggest Double : {0}", double.MaxValue);
            //double dblPiVal = 3.14159265358979;
            //double dblBigNum = 3.00000000000002;
            //Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            //Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            //float fltPiVal = 3.141592F;
            //float fltBigNum = 3.000002F;
            //Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum)

            //// Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character 
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // long : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            /* Multi
             * Line
             * Comment */

            ////Type Casting / Conversion
            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double dblFromStr = double.Parse("1.234");

            //string strVal = dblFromStr.ToString();
            //Console.WriteLine($"Data type : {strVal.GetType()}");
            //double dblNum = 12.345;
            //Console.WriteLine($"Integer : {(int)dblNum}"); //Explicit Conversion: Lose Data
            //int intNum = 10;
            //long longNum = intNum;

            //// Formatting Output
            //Console.WriteLine("Currency : {0:c}", 23.455);
            //Console.WriteLine("Pad with 0s : {0:d4}", 23);
            //Console.WriteLine("3 Decimals : {0:f3}", 23.4555555);
            //Console.WriteLine("Commas : {0:n4}", 2300);


            ////Strings
            //string randString = "This is a string";
            //Console.WriteLine("String Length : {0}", randString.Length);
            //Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            //Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            //Console.WriteLine("Remove String : {0}", randString.Remove(10, 6));
            //Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));
            //Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));
            //Console.WriteLine("Compare A to B : {0}", 
            //    String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            ////Compare strings and ignore case
            //// < 0 : str1 preceeds str2
            //// 0 : Equal
            //// > 0 : str2 preceeds str1
            //Console.WriteLine("---------------");
            //Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
            //Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
            //Console.WriteLine("Trim : {0}", randString.Trim());
            //Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            //Console.WriteLine("Lowercase : {0}", randString.ToLower());
            //string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            //Console.Write(newString + "\n");
            //// \' \" \\ \t \a
            ////Verbatim Strings
            //Console.WriteLine(@"Exactly what I typed\n");


            ////Arrays
            //int[] favNums = new int[3];
            //favNums[0] = 23;
            //Console.WriteLine("favNum 0 : {0}", favNums[0]);
            //string[] customers = {"Bob", "Sally", "Sue"};
            //var employees = new[] { "Mike", "Paul", "Rick" };
            //object[] randomArray = {"Paul", 45, 1.234};
            //Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            //Console.WriteLine("Array Size : {0}", randomArray.Length);
            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    Console.WriteLine("Array : {0} : Value : {1}", i, randomArray[i]);
            //}
            //Console.WriteLine("------------------------");
            //string[,] custNames = new string[2, 2]
            //{
            //    {"Bob", "Smith"},
            //    {"Sally", "Smith"}
            //};
            //Console.WriteLine("MD Value : {0}", custNames.GetValue(1, 0));
            //for(int i = 0; i < custNames.GetLength(0); i++)
            //{
            //    for (int j = 0; j < custNames.GetLength(0); j++)
            //    {
            //        Console.WriteLine("{0}", custNames[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] randNums = { 1, 4, 9, 2 };
            //PrintArray(randNums, "ForEach");
            //Console.WriteLine("-------------------------");

            //Array.Sort(randNums);
            //Array.Reverse(randNums);
            //Console.WriteLine("1 at index: {0}", Array.IndexOf(randNums,1));
            //randNums.SetValue(0, 1);
            //int[] srcArray = { 1, 2, 3 };
            //int[] destArray = new int[2];
            //int startInd = 0;
            //int length = 2;
            ////Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            //Array.Copy(srcArray, startInd, destArray, 0, length);
            //PrintArray(destArray, "Copy");
            //Array anotherArray = Array.CreateInstance(typeof(int), 10);
            //srcArray.CopyTo(anotherArray, 5);
            //foreach(int m in AnotherArray)
            //{
            //    Console.WriteLine("CopyTo : {0}", m);
            //}

            //int[] numArray = { 1, 11, 22 };
            //Error Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
        }
    }
}