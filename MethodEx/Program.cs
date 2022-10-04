using System;

namespace MethodEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string number = "512";
            //int lastNumber = number.Length;
            ////int lastNumber = int.Parse("512") % 10;
            //Console.WriteLine(lastNumber);

            //Ex 1
            //Console.Write("Enter your name: ");
            //GetName(Console.ReadLine());

            ////Ex 2
            //Console.Write("Enter first number: ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int b = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //int c = Int32.Parse(Console.ReadLine());

            //GetMax(a, b);
            //GetMax(a, c);

            //Console.WriteLine("Biggest number is {0}", a);

            //Ex 3

            //Console.Write("Enter a number: ");
            //string number = Console.ReadLine();

            //number=number[number.Length-1].ToString();

            //GetNum(number);

            //Ex4
            //int[] arr = { 5, 2, 4, 4, 5, 6, 7, 3, 5, 10, 3 };
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = NoOfoccurence(arr, number);
            //Console.WriteLine(result);

            //int[] arr = { 1, 2, 3, 4, 5, };
            //Console.WriteLine("enter a no");
            //int no = int.Parse(Console.ReadLine());
            //int result = ToCheckNeighbors(arr, no);
            //Console.WriteLine(result);

            //No 10 solution
            //Console.WriteLine("enter a num");
            //int number = int.Parse((Console.ReadLine()));
            //for (int i = 1; i < 101; i++)
            //{
            //    Console.WriteLine("{0}! = {1}", i, Factorial(i));
            //}
            //Console.ReadLine();
           
        }

        //Ex 1
        static void GetName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        //Ex 2
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                a = first;
            }
            else a = second;
        }

        //Ex 3
        static void GetNum(string number)
        {
            //int lastNumber = int.Parse(number);
            switch (number)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                case "0":
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;

            }
        }

        static int NoOfoccurence(int[] numbers, int givenNumber)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == givenNumber)
                {
                    count++;
                }
            }
            return count;
        }

        static int ToCheckNeighbors(int[] no, int index)
        {
            int neighbors = 0;
            if ((index < 0) || (index >= no.Length - 1))
            {
                Console.WriteLine(no.Length);
            }
                return neighbors;
        }

        static int ToReverseNo()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return reverse;

        }

        //No 10 solution
        static int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        //No 11 solution

       
    }
}
