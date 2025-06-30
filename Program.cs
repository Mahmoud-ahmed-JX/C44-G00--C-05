using System;
using System.Diagnostics;

namespace asmnt5
{
    internal class Program
    {
        #region q1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
        public static void Q1()
        {
            int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region q2.Write a program that allows the user to insert an integer then print a multiplication table up to 12.

        public static void Q2()
        {
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * num);
            }
        }

        #endregion

        #region q3.Write a program that allows to user to insert number then print all even numbers between 1 to this number
        public static void Q3()
        {
            int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        #endregion

        #region q6.Write a program to allow the user to enter a string and print the REVERSE of it.
        public static void Q6()
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
           
            string newstring = "";
            for (int i = s.Length- 1; i >= 0; i--)
            {
                
                    newstring += s[i];
            }
            Console.WriteLine(newstring);
        }
        #endregion

        #region q7.Write a program to allow the user to enter int and print the REVERSED of it.
        public static int Q7()
        {

            int num;
            Console.WriteLine("enter a number");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("enter a valid number");
            }

            int rev = 0;
            while (num % 10 != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }


            return rev;
        }
        #endregion

        #region q8.Write a program in C# Sharp to find prime numbers within a range of numbers.
        public static void Q8() {
            Console.WriteLine("enter the start of range");
            int start;
            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.WriteLine("enter a valid number");
            }

            Console.WriteLine("enter the end of range");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("enter a valid number");
            }

            for (int i = start; i <= end; i++) {
                bool flag=true;
                for (int j = 2; j < i; j++) {
                    if (i%j ==0) {
                        flag = false;
                            }
                    
                }
                if (i!=1&&flag == true )
                {
                    Console.Write(i + " ");

                }
            }
        }
        #endregion

        #region q9.Write a program in C# Sharp to convert a decimal number into binary without using an array.
        public static int Q9()
        {
            Console.WriteLine("enter a decimal number");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("enter a valid number");
            }
            int binaryNum = 0;
            while (num >0)
            {
                binaryNum = binaryNum*10+(num % 2 == 0 ? 0 : 1);
                num /= 2;
            }

            int rev = 0;
            while (binaryNum >0)
            {
                rev = rev * 10 + binaryNum % 10;
                binaryNum /= 10;
            }

            return rev;
        }
        #endregion

        #region q11.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
        public static void Q11()
        {
            int num;
            Console.WriteLine("enter a number");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("enter a valid number");

            };

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region q12.Write a program in C# Sharp to find the sum of all elements of the array.
        public static int Q12(int[] arr)
        {
            int sum = 0;
            for(int i = 0;i < arr.Length; i++)
            {
                sum+= arr[i];
            }
            return sum;
        }
        #endregion

        #region q13.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        public static void Q13(int[] arr1, int[] arr2)
        {
            //can take two arrays of the same size or even not
            int[] mergedArr = new int[arr1.Length + arr2.Length];
            int i = 0;

            //before we sort them i will merge them 
            for (int j = 0; j < arr1.Length; j++) { mergedArr[i] = arr1[j]; i++; }
            for (int j = 0; j < arr2.Length; j++) { mergedArr[i] = arr2[j]; i++; }


            //bubble sort
            for (int j = 0; j < mergedArr.Length - 1; j++)
            {
                //this -j for optimization(i've searched) because always the biggest el pushed at the end
                for (int k = 0; k < mergedArr.Length - 1 - j; k++)
                {
                    if (mergedArr[k] > mergedArr[k + 1])
                    {
                        //swapping process
                        int tmp = mergedArr[k];
                        mergedArr[k] = mergedArr[k + 1];
                        mergedArr[k + 1] = tmp;
                    }
                }
            }

            for (int j = 0; j < mergedArr.Length; j++)
            {
                Console.Write(mergedArr[j] + " ");
            }
        }
        #endregion

        #region q14.Write a program in C# Sharp to count the frequency of each element of an array.
        public static void Q14(int[] arr) {
            bool[] freq = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                int c = 0;

                if (freq[i])
                {
                    continue;
                }
                Console.Write($"the freq of {arr[i]} : ");

                for(int j = i; j < arr.Length; j++){
                    if (arr[i] == arr[j])
                    {
                        freq[j] = true; 
                        
                        c++;
                    }
                }
                Console.WriteLine(c);
            }
        }
        #endregion

        #region q15.Write a program in C# Sharp to find maximum and minimum element in an array
        public static void Q15(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"max value= {max} , min value= {min}");
        }
        #endregion

        #region q16.Write a program in C# Sharp to find the second largest element in an array.
        public static int Q16(int[] arr) { 
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) {
                    max = arr[i]; 
                }
            }

            int secMax=int.MinValue;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > secMax && max != arr[i]) {
                    secMax=arr[i];
                }
            }

            return secMax;
        }

        #endregion

        #region q17.Consider an Array of Integer values with size N, having values as    
 

        public static void Q17()
        {
            Console.WriteLine("enter the length of the array");
            int.TryParse(Console.ReadLine(), out int n);
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter the {i + 1} element");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            int dis = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                       if(dis< j - i - 1)
                        dis = j - i - 1;
                    }

                }
                Console.WriteLine(dis);



            }
            Console.WriteLine($"the distance between the two cells is {dis}");
        }
        #endregion

        #region q18.Given a list of space separated words, reverse the order of the words
        public static void Q18()
        {
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            string newstring = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    newstring += $"{arr[i]}";

                }
                else
                    newstring += $"{arr[i]} ";
            }
            Console.WriteLine(newstring);
        }

        #endregion

        #region q19.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
        public static void Q19()
        {
            Console.WriteLine("enter the numbers of rows");
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine("enter the number of columns");
            int.TryParse(Console.ReadLine(), out int c);

            int[,] arr1=new int[r,c];
            int[,] arr2 = new int[r,c];
            for(int i=0; i<arr1.GetLength(0); i++)
            {
                Console.WriteLine($"enter the data of the {i+1} row");
                for(int j=0; j<arr1.GetLength(1); j++) {
                    Console.WriteLine($"enter the {j+1} element");
                    int.TryParse(Console.ReadLine(), out arr1[i, j]);
                }
            }

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
               
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i,j]= arr1[i,j];
                }
            }

            for (int i = 0; i < arr2.GetLength(0); i++)
            {

                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        #endregion

        #region q20.Write a Program to Print One Dimensional Array in Reverse Order
        public static void Q20(int[] arr)
        {
            for (int i = arr.Length; i >= 0; i--) {

                Console.WriteLine(arr[i]);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //Q1();

            //Q2();

            //Q3();

            //Q6();

            //Console.WriteLine(Q7());

            //Q8();

            //Console.WriteLine( Q9());

            //Q11();

            //Console.WriteLine( Q12([1,2,3,4,5]));

            //Q13([2, 1, 9, 4], [5, 3, 7, 6]);

            //Q14([1,1,2,1,3,2,3]);

            //Q15([1,2,3,4,5]);

            //Console.WriteLine( Q16([1, 2, 3, 4, 5]));
            //Q17();


        }
    }
}
