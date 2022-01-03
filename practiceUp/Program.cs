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

        }

        public double GetTrapezoidArea(double longhbase, double shortbase, double height )
        {
            double area = (1 / 2) * (longhbase + shortbase) * height;
            return area;
        }

        public string DataOfACompany()
        {
            string NameOfEmployees;
            //NameOfEmployees = ("sola", "kemi", "sade", "bola", "atinuke",);
            return default;
        }
    }
}
