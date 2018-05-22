using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Scientific_Calculator
{
    /// <summary>
    /// Main form, contains the calculator itself and buttons to open all the other forms as dialog windows
    /// </summary>
    public partial class frmCalculator : Form
    {
        private List<string> _operationList = new List<string>();
        private string _currentNumber = "";
        /// <summary>
        /// Constructor
        /// </summary>
        public frmCalculator()
        {
            InitializeComponent();
        }

        #region Calculator button events

        #region Numbers

        private void cmdZero_Click(object sender, EventArgs e)
        {
            _currentNumber += "0";
            DisplayChar("0");
        }

        private void cmdOne_Click(object sender, EventArgs e)
        {
            _currentNumber += "1";
            DisplayChar("1");
        }

        private void cmdTwo_Click(object sender, EventArgs e)
        {
            _currentNumber += "2";
            DisplayChar("2");
        }

        private void cmdThree_Click(object sender, EventArgs e)
        {
            _currentNumber += "3";
            DisplayChar("3");
        }

        private void cmdFour_Click(object sender, EventArgs e)
        {
            _currentNumber += "4";
            DisplayChar("4");
        }

        private void cmdFive_Click(object sender, EventArgs e)
        {
            _currentNumber += "5";
            DisplayChar("5");
        }

        private void cmdSix_Click(object sender, EventArgs e)
        {
            _currentNumber += "6";
            DisplayChar("6");
        }

        private void cmdSeven_Click(object sender, EventArgs e)
        {
            _currentNumber += "7";
            DisplayChar("7");
        }

        private void cmdEight_Click(object sender, EventArgs e)
        {
            _currentNumber += "8";
            DisplayChar("8");
        }

        private void cmdNine_Click(object sender, EventArgs e)
        {
            _currentNumber += "9";
            DisplayChar("9");
        }

        #endregion

        #region Constants

        private void cmdLightSpeed_Click(object sender, EventArgs e)
        {

        }

        private void cmdNA_Click(object sender, EventArgs e)
        {

        }

        private void cmdPi_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Various input

        private void cmdComma_Click(object sender, EventArgs e)
        {
            _currentNumber += ".";
            DisplayChar(".");
        }

        private void cmdInvert_Click(object sender, EventArgs e)
        {
            DisplayChar("-", _currentNumber.Length * -1);
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, "-");
        }

        private void cmdOpenParenthesis_Click(object sender, EventArgs e)
        {

        }

        private void cmdCloseParenthesis_Click(object sender, EventArgs e)
        {

        }

        private void cmdDel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Converting

        private void cmdConvDecHex_Click(object sender, EventArgs e)
        {

        }
        private void cmdConvDecOct_Click(object sender, EventArgs e)
        {

        }

        private void cmdConvDecBin_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Operators

        #region simple operators
        /// <summary>
        /// Gives the sum of two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlus_Click(object sender, EventArgs e)
        {
            DisplayChar(" + ");
            EndCurrentNumber();
            _operationList.Add(" + ");
        }

        /// <summary>
        /// Gives the substraction of a number by another
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinus_Click(object sender, EventArgs e)
        {
            DisplayChar(" - ");
            EndCurrentNumber();
            _operationList.Add(" - ");
        }

        /// <summary>
        /// Gives the multiplicaiton of two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMult_Click(object sender, EventArgs e)
        {
            DisplayChar(" x ");
            EndCurrentNumber();
            _operationList.Add(" * ");
        }

        /// <summary>
        /// Gives the division of a number by another
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDiv_Click(object sender, EventArgs e)
        {
            DisplayChar(" / ");
            EndCurrentNumber();
            _operationList.Add(" / ");
        }

        /// <summary>
        /// Gives the reciprocal (1/x) of a non-null number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReciprocal_Click(object sender, EventArgs e)
        {
            DisplayChar("1 / ", _currentNumber.Length * -1);
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " 1/ ");
        }

        /// <summary>
        /// Gives the factorial of a positive number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFactorial_Click(object sender, EventArgs e)
        {
            DisplayChar("!");
            EndCurrentNumber();
            _operationList.Add("!");
        }

        /// <summary>
        /// Gives the absolute value of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAbsValue_Click(object sender, EventArgs e)
        {
            DisplayChar("|", _currentNumber.Length * -1);
            DisplayChar("|");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " abs(");
            _operationList.Add(")");

        }

        /// <summary>
        /// Rounds a number to the nearest integer. .5 rounds to superior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRound_Click(object sender, EventArgs e)
        {
            DisplayChar("Round(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " round(");
            _operationList.Add(", 0)");
        }

        #endregion

        #region Trigonometry

        private void cmdSin_Click(object sender, EventArgs e)
        {
            DisplayChar("Sin(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " sin(rad(");
            _operationList.Add("))");
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            DisplayChar("Cos(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " deg(cos(");
            _operationList.Add("))");
        }

        private void cmdTan_Click(object sender, EventArgs e)
        {
            DisplayChar("Tan(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " deg(tan(");
            _operationList.Add("))");
        }

        private void cmdInvSin_Click(object sender, EventArgs e)
        {
            DisplayChar("InvSin(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " rad(asin(");
            _operationList.Add("))");
        }

        private void cmdInvCos_Click(object sender, EventArgs e)
        {
            DisplayChar("InvCos(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " rad(acos(");
            _operationList.Add("))");
        }

        private void cmdInvTan_Click(object sender, EventArgs e)
        {
            DisplayChar("InvTan(", _currentNumber.Length * -1);
            DisplayChar(")");
            EndCurrentNumber();
            _operationList.Insert(_operationList.Count - 1, " rad(atan(");
            _operationList.Add("))");
        }

        #endregion

        #region Complex operators

        private void cmdSquare_Click(object sender, EventArgs e)
        {
            DisplayChar("^2");
            EndCurrentNumber();
            _operationList.Add("^2");
        }

        private void cmdSqrt_Click(object sender, EventArgs e)
        {

        }

        private void cmdExponentiation_Click(object sender, EventArgs e)
        {

        }

        private void cmdRoot_Click(object sender, EventArgs e)
        {

        }

        private void cmdExponential_Click(object sender, EventArgs e)
        {

        }

        private void cmdLog_Click(object sender, EventArgs e)
        {

        }

        private void cmdLn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion



        private void cmdClear_Click(object sender, EventArgs e)
        {
            rtxtDisplay.Clear();
            _operationList.Clear();
            _currentNumber = "";
        }

        /// <summary>
        /// Ends the current number, then calls the Calculation.Calculate method to solve the operation contained in _operationList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEqual_Click(object sender, EventArgs e)
        {
            EndCurrentNumber();
            double result = Calculation.Solve(_operationList);
            rtxtDisplay.Text += " = " + result.ToString();
            _operationList.Clear();
            _currentNumber = result.ToString();
        }

        #endregion

        /// <summary>
        /// Ends the entry of the current number and stores it in the _operationList
        /// </summary>
        private void EndCurrentNumber()
        {
            _operationList.Add(_currentNumber);
            _currentNumber = "";
        }

        private void DisplayChar(string sign, int position = 0)
        {
            rtxtDisplay.Text = rtxtDisplay.Text.Insert(rtxtDisplay.TextLength + position, sign);
        }

        private void cmdHistory_Click(object sender, EventArgs e)
        {

        }


        private void cmdSettings_Click(object sender, EventArgs e)
        {

        }

        private void cmdGraphDisplayer_Click(object sender, EventArgs e)
        {

        }
    }
}
