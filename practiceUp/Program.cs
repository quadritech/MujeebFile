using System;

namespace practiceUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };  

            //for (int i = 0; i >= numbers.Length; i++) ;

            //Console.WriteLine(numbers.Length);


            //string[] localGovt = new string[] { "awori", "ikeja", "shomolu", "ikotun" };
            //localGovt[2] = "yaba";

            //if (localGovt[2] == "jones")
            //{
            //    Console.WriteLine(localGovt[2]);
            //}
            //else
            //{
            //    Console.WriteLine(localGovt[2] + " is not a localGovt");
            //}

            //Console.WriteLine(GetTrapezoidArea(3, 4, 5));
            //Console.WriteLine(GetData("segun", 15));


            //int numberArg = 3;
            //// Copying the value 3 of the argument numberArg to the
            //// parameter numberParam
            //PrintNumber(numberArg);
            //Console.WriteLine("in the Main() method numberArg is: " +
            //numberArg);

           

        }

        public static double GetTrapezoidArea(double longhbase, double shortbase, double height)
        {
            double area = ((1.0 / 2.0) * ((longhbase + shortbase) * height));
            return area;
        }

        //public static string GetData(string NameOfEmployees, int age)
        //{
        //    string Data = NameOfEmployees + age;
        //    return Data;
        //}

        //static void PrintNumber(int numberParam)
        //{
        //    // Modifying the primitive-type parameter
        //    numberParam = 5;
        //    Console.WriteLine("in PrintNumber() method, after " +
        //    "modification, numberParam is: {0}", numberParam);
        //}

        //static void ModifyArray(int[] arrParam)
        //{
        //    arrParam[0] = 5;
        //    Console.WriteLine("numparam is a number");
        //    PrintArray(arrParam);
        //}

        //static void PrintArray(int[] arrParam)
        //{
        //    Console.Write("[");
        //    int length = arrParam.Length;
        //    if (length > 0)
        //    {
        //        Console.Write(arrParam[0].ToString());
        //        for (int i = 1; i < length; i++)
        //        {
        //            Console.Write(", {0}", arrParam[i]);
        //        }
        //    }
        //    Console.WriteLine("]");
        //}
    }
}
