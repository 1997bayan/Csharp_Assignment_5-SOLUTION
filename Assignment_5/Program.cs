using System.Reflection.Metadata;
using System.Reflection;
using System.ComponentModel;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics.Metrics;
using System.Buffers.Text;
using System.Text;

namespace Assignment_5
{
    internal class Program
    {

        public static void ByValue_Increment(int value)
        {
            value++;
           
        }
        public static void ByRef_Increment(ref int value)
        {
            value++;

        }

        static void ModifyArray(int[] Arr)
        {
            Arr[0] = 1000;

            int[] arr = new int[] { 1000, 200, 555 };

        }

        static void Ref_ModifyArray(ref int[] Arr)
        {
            Arr[0] = 1000;

            Arr = new int[] { 1000, 200, 555 };

        }

        static void SumSub (int x , int y , out int sum , out int sub)
        {
            sum = x + y;
            sub = x - y ;

        } 

        public static int sum_Of_the_digit (int number)
        {   int sum = 0;
            string number_String = Convert.ToString(number);
            for (int i = 0; i < number_String.Length; i++)
            {
                int digit = number_String[i] - '0';
                sum += digit;
            }
            return sum;
        }


        public static bool IsPrime_ (int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            else if ((n % 2 == 0) || (n % 3 == 0))
            { return false; }
                
            return true;
        }


        public static void MinMaxArray(int[] arr,ref int min, ref int max) // {10,4,5}
        {
             max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min) { 
                    min = arr[i];
                }

            }


        }

        public static long factorial_of_the_number (int x) 
        { long result = 1;
            for (int i = 1; i <= x; i++) { 

                result = result * i;
          
            }
            return result;
        }

        public static string ChangeChar(string word, int index, char ch)
        {

           StringBuilder sb = new StringBuilder(word);
           sb[index] =ch;
            return sb.ToString();

        }


            







        static void Main(string[] args)
        {
            #region Q1:- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //**Passing by Value**:

            //-When passing parameters by value, a copy of the actual parameter's value is made in the function. Changes made to the parameter inside the function do not affect the original value.    
            //Example Increment function

            int number = 6;
            ByValue_Increment(number);
            Console.WriteLine(number); //output:- 6

            //When passing parameters by reference using the ref keyword, the method receives a reference to the actual parameter, not a copy.
            //This means that any changes made to the parameter inside the method will affect the original value.
            int number2 = 6;
            ByRef_Increment(ref number2);
            Console.WriteLine(number2); //output:- 7
            Console.WriteLine(" ==================================== ");
            #endregion


            #region Q2 :  Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            /* (Reference type parameters) by value */
            //When passing parameters in a reference type (like an array) by value, the method receives a copy of the reference (address) to the original object.
            //This means:
            //1. * *Accessing and Modifying Elements * *: The method can use this reference to access and modify the elements of the array. Any changes made to the elements of the array inside the method will affect the original array because both the original variable and the method parameter **reference the same array.* *
            //2. * *Cannot Change the Reference Itself**: However, the method cannot change the reference to point to a different array. In other words, the method cannot make the original variable refer to a different array
            int[] values = { 5, 4, 3, 4, 5 };
            ModifyArray(values);
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(" ==================================== ");

            //When you pass a reference type parameter by reference, you are passing the actual reference itself.
            //This allows the method to modify the object and change the reference to point to a different object.
            int[] values2 = { 12, 43, 33, 44, 54 };
            Ref_ModifyArray(ref values2);
            foreach (int value in values2)
            {
                Console.WriteLine(value);  // output :1000 200 555
             

            }
            Console.WriteLine(" ==================================== ");


            #endregion


            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            bool Flag = true;
            //int num1;
            //do {
            //    Console.Write(" Please enter the first number:  ");
            //    Flag = int.TryParse(Console.ReadLine() , out  num1);

            //} while (!Flag);



            //int num2;
            //do
            //{
            //    Console.Write(" Please enter the Second number:  ");
            //    Flag = int.TryParse(Console.ReadLine(), out  num2);

            //} while (!Flag);

            //int sumResult;
            //int SubResult;
            //SumSub(num1, num2 ,out sumResult , out SubResult);
            //Console.WriteLine($"{num1} + {num2} = {sumResult} \n {num1} - {num2} = {SubResult} ");

            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7

            int num3;
            do
            {
                
                Console.Write(" Please enter a number:  ");
                Flag = int.TryParse(Console.ReadLine(), out num3);

            } while (!Flag);

            int SumResult = sum_Of_the_digit(num3);
            Console.WriteLine(SumResult);
            Console.WriteLine(" ==================================== ");



            #endregion

            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            int num4;
            do
            {

                Console.Write("Please enter a number:  ");
                Flag = int.TryParse(Console.ReadLine(), out num4);

            } while (!Flag);

            bool IsPrime = IsPrime_(num4);
            if (IsPrime)
            {
                Console.WriteLine("The number is prime ");
            }
            else
            {
                Console.WriteLine("The number is not prime ");
            }
            Console.WriteLine(" ==================================== ");


            #endregion


            #region Q6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int MinResult =0 , MaxResult=0 ;
            MinMaxArray(numbers, ref MinResult,ref MaxResult);

            Console.WriteLine($"The min number is {MinResult} , and the max number is {MaxResult}" );


            #endregion

            #region Q7:Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            int num6;
            do
            {

                Console.Write(" Please enter a number TO calculate the factorial of the number :  ");
                Flag = int.TryParse(Console.ReadLine(), out num6);

            } while (!Flag);

           long result = factorial_of_the_number(num6);
            Console.WriteLine(result);

            #endregion

            #region Q8 :Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            string name = "Bayan";
            int index = 0;
            char cha = 'R';
            string result2 = ChangeChar(name, index, cha);
            Console.WriteLine(result2);


            #endregion
        }
    }
}
