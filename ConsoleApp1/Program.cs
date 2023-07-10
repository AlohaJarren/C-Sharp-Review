using System;
using System.Globalization;
using System.Text;

namespace Consolepp1
{
    public class Program
    {

        // ------------ FUNCTIONS ------------

        //static void PrintArray(int[] intArray, string mess)
        //{
        //    foreach (int k in intArray)
        //    {
        //        Console.WriteLine("{0} : {1}", mess, k);
        //    }
        //}

        //static double DoDivision(double x, double y)
        //{
        //    if (y == 0)
        //    {
        //        throw new System.DivideByZeroException();
        //    }
        //    return x / y;
        //}

        //// Functions
        // <Access Specifier> <Return Type> <Method Name>(Parameters) 
        // { <body> }

        // Access Specifier determines whether the function can be called from another class
        
        // public : Can be accessed from another class
        // private : Can't be accessed from another class
        // protected : Can't be accessed by class, but accessible through derived classes

        //private static void SayHello()
        //{
        //    string name = "";
        //    Console.Write("What is your name : ");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Hello {0}", name);
        //}

        //static double GetSum(double x = 1, double y = 1)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //    return x + y;
        //}

        //// Out Parameter
        //static void DoubleIt(int x, out int solution)
        //{
        //    solution = x * 2;
        //}

        //// Pass By Reference
        //public static void Swap(ref int num3, ref int num4)
        //{
        //    int temp = num3;
        //    num3 = num4;
        //    num4 = temp;
        //}

        //// Passing Unknown Number of Parameters
        //static double GetSumMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach(int i in nums)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //// Name Parameters
        //static void PrintInfo(string name, int zipCode)
        //{
        //    Console.WriteLine("{0} lives in the zipcode {1}", name, zipCode);
        //}

        //// Method Overloading
        //static double GetSum2(double x = 1, double y = 1)
        //{
        //    return x + y;
        //}

        //static double GetSum2(string x = "1", string y = "1")
        //{
        //    double dblX = Convert.ToDouble(x);
        //    double dblY = Convert.ToDouble(y);
        //    return dblX + dblY;
        //}

        //// Enumerated Types
        //static void PaintCar(CarColor cc)
        //{
        //    Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        //} 

        // ------------ END OF FUNCTIONS ---------------

        //enum CarColor : byte
        //{
        //    Orange = 1,
        //    Blue,
        //    Green,
        //    Red,
        //    Yellow
        //}

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

            ////Conditionals
            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || !
            //int age = 17;
            //if ((age >= 5) && (age <= 8))
            //{
            //    Console.WriteLine("Go to elementary school");
            //}
            //if ((age > 7) && (age < 13))
            //{
            //    Console.WriteLine("Go to middle school");
            //}
            //if ((age > 13) && (age < 19))
            //{
            //    Console.WriteLine("Go to high school");
            //} else { Console.WriteLine("Go to college"); }

            //if ((age < 14) || (age > 67))
            //{
            //    Console.WriteLine("You shouldn't work");
            //}
            //Console.WriteLine("! true = " + (!true));

            //bool canDrive = age >= 16 ? true : false;

            //switch (age)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Go to Day Care");
            //        break;
            //    case 3:
            //    case 4: 
            //        Console.WriteLine("Go to Preschool");
            //        break;
            //    case 5:
            //        Console.WriteLine("Go to Kindergarten");
            //        break;
            //    default:
            //        Console.WriteLine("Go to another school");
            //        goto OtherSchool;
            //}

            //OtherSchool:
            //    Console.WriteLine("Elementary, Middle, High School");

            //string name2 = "Derek";
            //string name3 = "Derek";
            //if(name2.Equals(name3, StringComparison.Ordinal))
            //{
            //    Console.WriteLine("Names are equal");
            //}


            //// While Loop
            //int i = 1;
            //while(i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 9) break;
            //    Console.WriteLine(i);
            //    i++
            //}

            //// Do-While Loop
            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11);
            //int numberGuessed = 0;
            //Console.WriteLine("Random Num : ", secretNumber);

            //do
            //{
            //    Console.WriteLine("Enter a number between 1 & 10 : ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());

            //} while (secretNumber != numberGuessed);

            //Console.WriteLine("You guessed it, it was {0}", secretNumber);


            ////Exception Handling
            //double num1 = 5;
            //double num2 = 0;

            //try
            //{
            //    Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can't divide by zero");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Cleaning Up");
            //}


            ////String Builder
            //StringBuilder sb = new StringBuilder("Random text");
            //StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);
            //Console.WriteLine("Capacity : {0}", sb2.Capacity);
            //Console.WriteLine("Length : {0}", sb2.Length);
            //sb2.AppendLine("\nMore important text");
            //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            //string bestCust = "Bob Smith";
            //sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            //Console.WriteLine(sb2.ToString());
            //sb2.Replace("text", "characters");
            //Console.WriteLine(sb2.ToString());
            //sb2.Clear();
            //sb2.Append("Random Text");
            //Console.WriteLine(sb.Equals(sb2));
            //sb2.Insert(11, " that's great");
            //Console.WriteLine(sb2.ToString());
            //sb2.Remove(11, 7);
            //Console.WriteLine(sb2.ToString()); 

            //// Functions
            //SayHello();
            //double x = 5;
            //double y = 4;
            //Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            //Console.WriteLine("x = {0}", x);

            //// Out Parameter
            //int solution;
            //DoubleIt(15, out solution);
            //Console.WriteLine("15 * 2 = {0}", solution);

            //// Pass By Reference
            //int num3 = 10;
            //int num4 = 20;
            //Console.WriteLine("Before Swap num3 : {0} num4 : {1}", num3, num4);
            //Swap(ref num3, ref num4);
            //Console.WriteLine("After Swap num3 : {0} num4 : {1}", num3, num4);

            //// Passing Unknown Number of Parameters
            //Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 2, 3));

            //// Name Parameters
            //PrintInfo(zipCode: 97203, name: "Jarren Calzone");

            ////Method Overloading
            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.0));
            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.0"));

            ////DateTime / Time Span
            //DateTime awesomeDate = new DateTime(1974, 12, 21);
            //Console.WriteLine("Day of the Week : {0}", awesomeDate.DayOfWeek);
            //awesomeDate = awesomeDate.AddDays(4);
            //awesomeDate = awesomeDate.AddMonths(1);
            //awesomeDate = awesomeDate.AddYears(1);
            //Console.WriteLine("New Date : {0}", awesomeDate.Date);

            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            //Console.WriteLine("New Time : {0}", lunchTime.ToString());


            ////Enumerated Types
            //CarColor car1 = CarColor.Blue;
            //PaintCar(car1);

        }
    }
}