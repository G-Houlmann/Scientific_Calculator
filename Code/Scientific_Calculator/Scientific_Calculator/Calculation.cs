using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using org.mariuszgromada.math.mxparser;


namespace Scientific_Calculator
{
    /// <summary>
    /// Class that handles all the mathematics of the program, and interpretes the operations inputs
    /// </summary>
    public class Calculation
    {
        #region Converting

        /// <summary>
        /// Converts a decimal number in a string to an hexadecimal number in a string
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string ConvDecHex(string dec)
        {
            string hex = "";
            uint nDec = uint.Parse(dec);
            hex = Convert.ToString(nDec, 16);
            return hex;
        }

        /// <summary>
        /// Converts a decimal number in a string to a binary number in a string
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string ConvDecBin(string dec)
        {
            string bin = "";
            uint nDec = uint.Parse(dec);
            bin = Convert.ToString(nDec, 2);
            return bin;
        }

        /// <summary>
        /// Converts a decimal number in a string to an octal number in a string
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string ConvDecOct(string dec)
        {
            string oct = "";
            uint nDec = uint.Parse(dec);
            oct = Convert.ToString(nDec, 8);
            return oct;
        }

        #endregion

        /// <summary>
        /// Solves the operation given in parameter with a list using mXParser
        /// </summary>
        /// <returns>a string containing the result</returns>
        public static string Solve(List<string> operationList)
        {
            //Converts the list of strings into a single string
            string opString = "";
            foreach (string s in operationList)
            {
                opString += s;
            }

            //Uses the Expression class, from the assembly mXParser
            Expression e = new Expression(opString);

            //Solves the operation with the calculate method from the Expression class
            double result = e.calculate();

            //Checks the syntax of the expression and sets the result to "Erreur de syntaxe" if the syntax was wrong
            string resultString = result.ToString();
            if (!e.checkSyntax())
            {
                resultString = "Erreur de syntaxe";
            }

            //Calls the ArchiveOperation method to store the operation in the database for the history
            ArchiveOperation(opString + " = " + result.ToString());

            return resultString;
        }

        /// <summary>
        /// Inserts the operation in the database for the history
        /// </summary>
        /// <param name="opString"></param>
        private static void ArchiveOperation(string opString)
        {
            DBAccess dba = new DBAccess();
            dba.InsertOperationInHistory(opString);
        }
    }
}
