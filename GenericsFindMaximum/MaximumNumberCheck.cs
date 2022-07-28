using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFindMaximum
{
    internal class MaximumNumberCheck
    {
        //This method is used to find which integer number is maximum
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
        //this method is used to find which float number is maximum
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
        //this method is used to find which String input is maximum
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }

            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
        //this method is used to find maximum integer number in array
        public static int findMax(int[] arr)
        {
            Array.Sort(arr); // the sort method from Array class is used to sort the array in ascending order
            Console.WriteLine("The sorted Integer array is :");
            for (int i = 0; i < arr.Length; i++) //this for loop is used to print values one by one from array
            {
                Console.WriteLine(arr[i]);
            }
            return arr[arr.Length-1]; // returning the last value in array i.e the maximum number
        }
        public static double findMax(double[] arr)
        {
            Array.Sort(arr); // the sort method from Array class is used to sort the array in ascending order
            Console.WriteLine("The sorted Double array is :");
            for (int i = 0; i < arr.Length; i++) //this for loop is used to print values one by one from array
            {
                Console.WriteLine(arr[i]);
            }
            return arr[arr.Length - 1]; // returning the last value in array i.e the maximum double number
        }
        public static string findStringMax(string[] arr)
        {
            Array.Sort(arr); // the sort method from Array class is used to sort the array in ascending order
            Console.WriteLine("The sorted String array is :");
            for (int i = 0; i < arr.Length; i++) //this for loop is used to print values one by one from array
            {
                Console.WriteLine(arr[i]);
            }
            return arr[arr.Length - 1]; // returning the last value in array i.e the maximum string
        }
    }
}
