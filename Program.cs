using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// To find a number Even or Odd
            //int num;
            //Console.WriteLine("Enter a number to find odd or even : ");
            // num = Convert.ToInt32(Console.ReadLine());
            //if(num%2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}



            // Print Odd Numbers in a Given Range
            //Console.WriteLine("Enter a starting number : ");
            //int Start = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a Ending number : ");
            //int End = Convert.ToInt32(Console.ReadLine());

            //for(int i = Start; i<=End; i++)
            //{
            //    if(i%2 != 0)
            //    {
            //        Console.WriteLine(i + "");
            //    }
            //}


            //Check Whether a Number is Positive or Not
            //int num;
            //Console.WriteLine("Number is : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //if(num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}else if(num == 0)
            //{
            //    Console.WriteLine("Number is zero");
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}


            // Find the Largest of Two Numbers
            //int a, b;
            //Console.WriteLine("Enter a number A : ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a number B : ");
            //b = Convert.ToInt32(Console.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine("A is greatest");
            //}else
            //{
            //    Console.WriteLine("B is greatest");
            //}



            // swapping of numbers
            //int num1, num2, temp;

            //Console.WriteLine("Enter a number 1 : ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a number 2 : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //temp = num1;
            //num1 = num2;
            //num2 = temp;

            //Console.WriteLine("number 1 : " + num1);
            //Console.WriteLine("number 2 : " + num2);


            // Number is divisible by 2 or not
            // Console.WriteLine("Enter a number  : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            // if(num%2 == 0)
            // {
            //     Console.WriteLine("Number is divisible by 2");
            // }
            // else
            // {
            //     Console.WriteLine("Number is Not divisible by 2");
            // }

            //sum of number divisible by 3 and 5 bt in range
            //int a, b, i, sum = 0;

            //for( i = 0; i<10; i++)
            //{
            //    a = i % 3;
            //    b = i % 5;

            //    if(a==0 || b== 0)
            //    {
            //        Console.WriteLine( i);
            //        sum = sum + i;
            //    }
            //    Console.WriteLine(sum);
            //}


            // number of bt 100 who multiply by 17
            //int a, i;
            //Console.WriteLine("Multiple of 17 :");

            //for(i=0; i<100; i++)
            //{
            //    a = i % 17;

            //    if(a == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //// sum of digits
            //int sum=0, num, r;
            //Console.WriteLine("Enter a digits : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while(num != 0)
            //{
            //    r = num % 10;
            //    num = num / 10;
            //    sum = sum + r;

            //}
            //Console.WriteLine("Sum of digits : " + sum);


            // // sum of digits Using Recursion
            //    Console.WriteLine("Enter a number : ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    int result = sumDigits(number);
            //    Console.WriteLine($"The sum of digits {number} is : {result}");

            //    Console.ReadLine();
            //}
            //static int sumDigits(int num)
            //{
            //    if (num == 0)
            //        return 0;
            //    return (num % 10) + sumDigits(num / 10);
            //}



            //// Reverse a number 
            //int num, reverse = 0;
            //Console.WriteLine("Enter a number : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (num != 0)
            //{
            //    reverse = reverse * 10;
            //    reverse = reverse + num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine("Reversed a enter number is : " + reverse);



            //Reverse a Number and Check if it is a Palindrome
            //Console.WriteLine("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int original = num;
            //int reversed = 0;

            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    reversed = reversed * 10 + digit;
            //    num /= 10;
            //}
            //Console.WriteLine("Reversed number :" + reversed);

            //if(reversed == original)
            //{
            //    Console.WriteLine("Number is Pallindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not a pallindrome");
            //}

            //  Sum of Two Binary Number
            //int b1, b2;
            //int rem = 0, i = 0;
            //int[] sum = new int[20];
            //Console.WriteLine("Enter a first binary Number : ");
            //b1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a second Binary Number : ");
            //b2 = Convert.ToInt32(Console.ReadLine());

            //while(b1!=0 && b2 != 0)
            //{
            //    sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
            //    rem = (b1%10 + b2%10 + rem) / 2;
            //    b1 = b1 / 10;
            //    b2 = b2 / 10;
            //}
            //if (rem != 0)
            //{
            //    sum[i++] = rem;
            //    --i;
            //    Console.WriteLine("Sum of two binary Number : ");
            //    while (i >= 0)
            //        Console.Write("{0}", sum[i--]);
            //}


            // multiply of two binary number 
            //Console.WriteLine("Enter a binary Number 1 : ");
            //string bin1 = Console.ReadLine();

            //Console.WriteLine("Enter a binary Number 2 : ");
            //string bin2 = Console.ReadLine();

            //// convert binary to decimal
            //int num1 = Convert.ToInt32(bin1 , 2);
            //int num2 = Convert.ToInt32(bin2, 2);

            //int product = num1 * num2;

            //string result = Convert.ToString(product, 2);

            //Console.WriteLine($"Product of {bin1} and {bin2} = {result}");



            //Perform All Arithmetic Operations
            //int num1, num2, result;
            //char option;
            //Console.WriteLine("Enter a first Number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a Second Number : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Main Menu :- ");
            //Console.WriteLine("1 . Addition : - ");
            //Console.WriteLine("2 . Subtraction : - ");
            //Console.WriteLine("3 . Multiplication : - ");
            //Console.WriteLine("4 . Division : - ");
            //Console.Write("Enter the operation you want to perform : ");
            //option = Convert.ToChar(Console.ReadLine());

            //switch(option)
            //{
            //    case '1':
            //        result = num1 + num2;
            //        Console.WriteLine("The result of the addition is {0}", result);
            //        break;
            //    case '2':
            //        result = num1 - num2;
            //        Console.WriteLine("The result of the Subtraction is {0}", result);
            //        break;
            //    case '3':
            //        result = num1 * num2;
            //        Console.WriteLine("The result of the Multiplication is {0}", result);
            //        break;
            //    case '4':
            //        result = num1 / num2;
            //        Console.WriteLine("The result of the Division is {0}", result);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}


            ////Perform Multiplication of Exponents of Same Base
            //Console.WriteLine("Enter a base number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a first Exponent : ");
            //int exp1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a Second Exponent : ");
            //int exp2 = Convert.ToInt32(Console.ReadLine());

            //int CombinedExponent = exp1 + exp2;
            //double result = Math.Pow(num, CombinedExponent);

            //Console.WriteLine($"{num}^{exp1} * {num} ^ {exp2} = {num} ^ {CombinedExponent}");
            //Console.WriteLine("Result = " + result);



            // // Table print
            // Console.WriteLine("Enter a table : ");
            // int num = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i<=10; i++)
            // {                            
            //         Console.WriteLine($"{num} x {i} = {num * i}");
            // }


            //char grade;
            //Console.WriteLine("Enter a grade in UpperCase : ");
            //grade = Convert.ToChar(Console.ReadLine());

            //switch (grade)
            //{
            //    case 'S':
            //        Console.WriteLine("Super ");
            //        break;
            //    case 'A':
            //        Console.WriteLine("VeryGood ");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Excellent ");
            //        break;
            //    case 'Y':
            //        Console.WriteLine("Absent ");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Fail ");
            //        break;
            //    default:
            //        Console.WriteLine("Error in grade ");
            //        break;

            //}


            // convert string uppercase to lowercase and lowercase to uppercase
            //Console.WriteLine("Enter a String : ");
            //string input = Convert.ToString(Console.ReadLine());
            //string result = "";

            //foreach(char c in input)
            //{
            //    if (char.IsLower(c))
            //    {
            //        result += char.ToUpper(c);
            //    }
            //    else if(char.IsUpper(c))
            //    {
            //        result += char.ToLower(c);
            //    }
            //    else
            //    {
            //        result += c;
            //    }
            //}
            //Console.WriteLine("Converted String : " + result);


            //height measurment

            //float height;
            //Console.WriteLine("Enter your height in cm : ");
            //height = float.Parse(Console.ReadLine());

            //if (height <= 150.0)
            //{
            //    Console.WriteLine("Short height");
            //}else if(height>=151.0 && height <= 170.0)
            //{
            //    Console.WriteLine("Average height");
            //}
            //else 
            //{
            //    Console.WriteLine("Taller .....");
            //}



            //Find the minimum/maximum range of data type
            //Console.WriteLine("The minimum range of decimal data : "+ Decimal.MinValue);
            //Console.WriteLine("The minimum range of Float data : " + Single.MinValue);
            //Console.WriteLine("The Maximum range of decimal data : " + Decimal.MaxValue);
            //Console.WriteLine("The Maximum range of Float data : " + Single.MaxValue);



            //  perform all aritmetic operation ;
            //double num1, num2, result;
            //char option;
            //Console.WriteLine("Enter a first number : ");
            //num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a second Number : ");
            //num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Main Menu : ");
            //Console.WriteLine("1.Addition :");
            //Console.WriteLine("2.Substraction :");
            //Console.WriteLine("3.Multiplication :");
            //Console.WriteLine("4.Division :");

            //Console.WriteLine("Enter the operation do you want to perform : ");
            //option = Convert.ToChar(Console.ReadLine());
            //switch (option)
            //{
            //    case '1':
            //        result = num1 + num2;
            //        Console.WriteLine("Addition of num 1 and num 2 is " + result);
            //        break;
            //    case '2':
            //        result = num1 - num2;
            //        Console.WriteLine("substraction of num 1 and num 2 is " + result);
            //        break;
            //    case '3':
            //        result = num1 * num2;
            //        Console.WriteLine("Multiplication of num 1 and num 2 is " + result);
            //        break;
            //    case '4':
            //        result = num1 / num2;
            //        Console.WriteLine("Division of num 1 and num 2 is " + result);
            //        break;
            //}



            // conditional logical operator 
            // int age;
            // Console.WriteLine("Enter a age : ");
            // age = Convert.ToInt32(Console.ReadLine());
            //bool adult = age >= 18 ? true : false;
            // Console.WriteLine("Adult : " + adult);




            //Fibonacci number : 
            //int i, count, f1 = 0, f2 = 1, f3 = 0;
            //Console.WriteLine("Enter your limit : ");
            //count = int.Parse(Console.ReadLine());
            //Console.WriteLine(f1);
            //Console.WriteLine(f2);
            //for(i = 0; i<count; i++)
            //{
            //    f3 = f1 + f2;
            //    Console.WriteLine(f3);
            //    f1 = f2;
            //    f2 = f3;
            //}



            //factorial 
            //int fact, i, num;
            //Console.WriteLine("Enter the num : ");
            //num = Convert.ToInt32(Console.ReadLine());
            //fact = num;
            //for(i = num-1; i>=1; i--)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("fact is " + fact);


















            Console.ReadLine();
        }
    }
}
