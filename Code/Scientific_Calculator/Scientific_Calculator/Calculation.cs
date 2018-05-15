using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Scientific_Calculator
{
    class Calculation
    {
        #region Private math methods

        #region simple operations
        /// <summary>
        /// returns the sum of two numbers
        /// </summary>
        /// <param name="x">The first number to be added</param>
        /// <param name="y">The second number to be added</param>
        /// <returns>the sum of x and y</returns>
        private double Sum(double x, double y)
        {

            return 0;
        }

        /// <summary>
        /// returns the product of two numbers
        /// </summary>
        /// <param name="x">The first number to be multiplied</param>
        /// <param name="y">The second number to be multiplied</param>
        /// <returns>the product of x and y</returns>
        private double Multiplication(double x, double y)
        {

            return 0;
        }

        /// <summary>
        /// Substracts one number to another
        /// </summary>
        /// <param name="x">The number from which "y" will be substracted</param>
        /// <param name="y">The number that will be substracted to "x"</param>
        /// <returns>the substraction of x by y</returns>
        private double Substraction(double x, double y)
        {

            return 0;
        }

        /// <summary>
        /// Divides one number by the other
        /// </summary>
        /// <param name="x">The number that will be divided by "y"</param>
        /// <param name="y">The number by which "x" will be divided</param>
        /// <returns>the division of x by y</returns>
        private double Division(double x, double y)
        {

            return 0;
        }


        /// <summary>
        /// Calculates the Reciprocal of a number
        /// </summary>
        /// <param name="x">The number whose reciprocal will be calculated</param>
        /// <returns>1 divided by x</returns>
        private double Reciprocal(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the absolute value of a number
        /// </summary>
        /// <param name="x">The number whose absolute value will be calculated</param>
        /// <returns>the absolute value</returns>
        private double AbsoluteValue(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the factorial of a number
        /// </summary>
        /// <param name="x">The number whose factorial will be calculated</param>
        /// <returns>The factorial of x</returns>
        private double Factorial(double x)
        {

            return 0;
        }

        #endregion
        #region Trigonometry

        /// <summary>
        /// Calculates the sine of a number
        /// </summary>
        /// <param name="x">The number whose sine will be calculated</param>
        /// <returns>The sine of x</returns>
        private double Sine(double x)
        {
            return 0;
        }

        /// <summary>
        /// Calculates the cosine of a number
        /// </summary>
        /// <param name="x">The number whose cosine will be calculated</param>
        /// <returns>The cosine of x</returns>
        private double Cosine(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the tangent of a number
        /// </summary>
        /// <param name="x">The number whose tangent will be calculated</param>
        /// <returns>The tangent of x</returns>
        private double Tangent(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the inverse sine of a number
        /// </summary>
        /// <param name="x">The number whose inverse sine will be calculated</param>
        /// <returns>The inverse sine of x</returns>
        private double InverseSine(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the inverse cosine of a number
        /// </summary>
        /// <param name="x">The number whose inverse cosine will be calculated</param>
        /// <returns>The inverse cosine of x</returns>
        private double InverseCosine(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the inverse tangent of a number
        /// </summary>
        /// <param name="x">The number whose inverse tangent will be calculated</param>
        /// <returns>The inverse tangent of x</returns>
        private double InverseTangent(double x)
        {

            return 0;
        }

        #endregion
        #region Powers, roots and exponentials
        
        /// <summary>
        /// Calculates the square of a number
        /// </summary>
        /// <param name="x">The number whose square will be calculated</param>
        /// <returns>the square of x</returns>
        private double Square(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the square root of a number
        /// </summary>
        /// <param name="x">The number whose square root will be calculated</param>
        /// <returns>the square root of x</returns>
        private double squareRoot(double x)
        {

            return 0;
        }


        /// <summary>
        /// Calculates a number raised to the power of another
        /// </summary>
        /// <param name="x">The base of the exponentiation</param>
        /// <param name="y">The exponent of the exponentiation</param>
        /// <returns>X raised to the power of y</returns>
        private double Exponentiation(double x, double y)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the n-th root of a number
        /// </summary>
        /// <param name="x">The number whose n-th will be calculated</param>
        /// <param name="y">The degree of the root</param>
        /// <returns>The y-th root of x</returns>
        private double Root(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the exponential of a number
        /// </summary>
        /// <param name="x">The number to the power of which e will be raised</param>
        /// <returns>e raised to the power of x</returns>
        private double Exponential(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the 10th base logarithm of a number
        /// </summary>
        /// <param name="x">The number whose 10th base logarithm will be calculated</param>
        /// <returns>The 10th base logarithm of x</returns>
        private double TenthBaseLogarithm(double x)
        {

            return 0;
        }

        /// <summary>
        /// Calculates the natural logarithm of a number
        /// </summary>
        /// <param name="x">The number whose natural logarithm will be calculated</param>
        /// <returns>the natural logarithm of x</returns>
        private double NaturalLogarithm(double x)
        {

            return 0;
        }

        #endregion

        #endregion


        /// <summary>
        /// Reads the operation string and transforms it into an array.
        /// The array contains all the math operations and numbers that will have to be used
        /// </summary>
        /// <returns>An array conaining the necesarry information to do the operation</returns>
        private string[] ReadOperation(string operationString)
        {
            return null;
        }

        /// <summary>
        /// Reads the array sent by ReadOperation and does all the mathematics to finally find the result of the operation.
        /// </summary>
        /// <returns></returns>
        private double Calculate(string[] operationArray)
        {
            return 0;
        }

        /// <summary>
        /// Sends the operation string to the ReadOperation method, then sends the resulted array to the Calculate method, thus obtaining the numeric result.
        /// </summary>
        /// <param name="operationString"></param>
        /// <returns></returns>
        public double Solve(string operationString)
        {
            return 0;
        }
    }
}
