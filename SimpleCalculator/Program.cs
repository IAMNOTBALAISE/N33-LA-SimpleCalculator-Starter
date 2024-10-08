﻿using System;
using CalcLibrary;



namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            double ConvertedResult1, ConvertedResult2;
            while (true)
            {
                Console.WriteLine("enter the first number in its numerical form:");
                string firstNumber = Console.ReadLine();
                bool res1 = InputConverter.ConvertInputToNumeric(firstNumber, out double convertedRes);
                if (res1 == true)
                {
                    ConvertedResult1 = convertedRes;
                    break;
                }
                else
                {
                    Console.WriteLine("numeric values only!");
                }
            }

            while (true)
            {
                Console.WriteLine("enter the second number in its numerical form:");
                string secondNumber = Console.ReadLine();
                bool res2 = InputConverter.ConvertInputToNumeric(secondNumber, out double convertedRes);
                if (res2 == true)
                {
                    ConvertedResult2 = convertedRes;
                    break;
                }
                else
                {
                    Console.WriteLine("numeric values only!");
                }
            }


            
            bool isvalid = false;

            while (!isvalid) {

                Console.WriteLine("\nEnter the operation you wish to perform" +
                    ": (ex: + or add, - or substract , x or multiply, / or division, ^ or power) : ");

                   string operation = Console.ReadLine();

                if (!CalcUtilities.IsValidOperator(operation)) {

                    Console.WriteLine("The operation is not good please try again  + or add, - or substract , x or multiply," +
                        " / or division, ^ or power ");
                }
                else
                {
                    isvalid = true;
                    double result = CalcUtilities.Calculate(operation, ConvertedResult1, ConvertedResult2);
                    Console.WriteLine("The value {0} {1} the value {2} is equal to {3:0.00}", ConvertedResult1, operation, ConvertedResult2, result);
                    Console.ReadLine();
                }


            }


           


           

         

           

        }

    }

   
        }
    


