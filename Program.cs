namespace Execises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //// Exercise 2
            //// Input a number (n) from the user and check if it is even or odd.

            //// Write your code here
            //while(true)
            //{
            //    //userInputToCheck = Console.ReadLine();
            //    Console.WriteLine("Please Enter the Input :");
            //    int n = int.Parse(Console.ReadLine());
            //    if(n==0)
            //    {
            //        break;
            //    }
            //    else if (n%2==0)
            //    {
            //        Console.WriteLine(n / 2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(n * 2);
            //    }

            //}



            // Exercise 3
            // Input 3 numbers from the user (x,y,z) and find the greatest of them.

            // Write your code here
            Console.WriteLine("Enter the sides of the Triangle:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            double Area = AreaofTriangle(x, y, z);
            Console.WriteLine("Area of the Triangle {0:f4}: " + Area);
            static double AreaofTriangle(int a, int b, int c)
            {

                double area;
                double s = (a + b + c) / 2;
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }



            //    // example 5 - loop
            //    bool stopProgram = false;

            //    while (stopProgram == false)
            //    {
            //        Console.Write("Please enter income: $");
            //        income = Convert.ToDecimal(Console.ReadLine());

            //        if (income > 400000)
            //        {
            //            taxRate = 0.5M;
            //            taxLiability = taxRate * income;
            //        }
            //        else if (income >= 0)
            //        {
            //            taxLiability = 0;
            //        }
            //        else
            //        {
            //            stopProgram = true;
            //        }

            //        Console.WriteLine("Tax liability is " + taxLiability);
            //    } // end while loop


            //    // Exercise 4
            //    // Input a value (n) from the user and calculate the sum of first n natural numbers.
            //    // Eg. n=5. sum = 1+2+3+4+5 = 15

            //    // Write your code here




            //    // Exercise 5
            //    // Input a value (n) from the user and display the following * pattern:
            //    // Input n=5
            //    // Output
            //    // *
            //    // **
            //    // ***
            //    // ****
            //    // *****

            //    // Write your code here




            //    // Exercise 6
            //    // Input a value (n) from the user and display the following * pattern:
            //    // Input n=5
            //    // Output
            //    //     *
            //    //    **
            //    //   ***
            //    //  ****
            //    // *****

            //    // Write your code here




            //    // example 6 - method
            //    income = Convert.ToDecimal(Console.ReadLine());
            //    taxLiability = ComputeTaxes(income);
            //    Debug.WriteLine("Tax liability is " + taxLiability);


            //    // Exercise 7
            //    // Write a method that accepts a parameter (n) and returns the sum of first n natural numbers.

            //    // Write your code here




            //    // example 7 - arrays
            //    decimal[] incomes = new decimal[] { 100.0M, 234532, 2443245.1M, 123443 };

            //    for (int i = 0; i < 4; i++)
            //    {
            //        Debug.WriteLine(incomes[i]);
            //    }


            //    // Exercise 8
            //    // Enter n numbers in an array and print all the even numbers.

            //    // Write your code here



            //    // Exercise 9
            //    // Enter n numbers in an array and find the highest and the smallest number.

            //    // Write your code here

            //}

            //static decimal ComputeTaxes(decimal income)
            //{
            //    decimal taxLiability;
            //    decimal taxRate;

            //    if (income < 400000)
            //        taxLiability = 0;
            //    else
            //    {
            //        taxRate = 0.5M;
            //        taxLiability = taxRate * income;
            //    }

            //    return taxLiability;
            //}
        }
    }
}
