﻿using System;
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
        private int _cursorPlace = -1;
        private int _decimalsAmount;
        private string addAfter = "";
        private int _ListCurrentExpressionStart = 0;
        private int _stringCurrentExpressionStart = 0;
        private int _stringCurrentExpressionEnd = 1;

        /// <summary>
        /// Predicate used to find whether a root value "rtVal" must be replaced in the operation's list
        /// </summary>
        Predicate<string> _preRtVal = (string s) => { return s.Contains("rtVal"); };

        /// <summary>
        /// Constructor
        /// </summary>
        public frmCalculator()
        {
            InitializeComponent();
            //Tests the database connection. If a connection cannot be opened, the application closes
            try
            {
                DBAccess dbaTest = new DBAccess();
                dbaTest.testConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de se connecter à la base de données. L'application va se fermer.");
                Environment.Exit(1);
            }
            Program.setSettingsToDefault();
            DBAccess dba = new DBAccess();
            _decimalsAmount = dba.GetSettingValue("DecimalsAmount");
            lblDecimalsAmount.Text = _decimalsAmount.ToString();
        }

        #region Calculator button events

        #region Numbers

        /// <summary>
        /// Displays a 0
        /// </summary>
        private void cmdZero_Click(object sender, EventArgs e)
        {
            _currentNumber += "0";
            DisplayString("0");
        }

        /// <summary>
        /// Displays a 1
        /// </summary>
        private void cmdOne_Click(object sender, EventArgs e)
        {
            _currentNumber += "1";
            DisplayString("1");
        }

        /// <summary>
        /// Displays a 2
        /// </summary>
        private void cmdTwo_Click(object sender, EventArgs e)
        {
            _currentNumber += "2";
            DisplayString("2");
        }

        /// <summary>
        /// Displays a 3
        /// </summary>
        private void cmdThree_Click(object sender, EventArgs e)
        {
            _currentNumber += "3";
            DisplayString("3");
        }

        /// <summary>
        /// Displays a 4
        /// </summary>
        private void cmdFour_Click(object sender, EventArgs e)
        {
            _currentNumber += "4";
            DisplayString("4");
        }

        /// <summary>
        /// Displays a 5
        /// </summary>
        private void cmdFive_Click(object sender, EventArgs e)
        {
            _currentNumber += "5";
            DisplayString("5");
        }

        /// <summary>
        /// Displays a 6
        /// </summary>
        private void cmdSix_Click(object sender, EventArgs e)
        {
            _currentNumber += "6";
            DisplayString("6");
        }

        /// <summary>
        /// Displays a 7
        /// </summary>
        private void cmdSeven_Click(object sender, EventArgs e)
        {
            _currentNumber += "7";
            DisplayString("7");
        }

        /// <summary>
        /// Displays a 8
        /// </summary>
        private void cmdEight_Click(object sender, EventArgs e)
        {
            _currentNumber += "8";
            DisplayString("8");
        }

        /// <summary>
        /// Displays a 9
        /// </summary>
        private void cmdNine_Click(object sender, EventArgs e)
        {
            _currentNumber += "9";
            DisplayString("9");
        }

        #endregion

        #region Constants

        /// <summary>
        /// Gets the light speed constant from the database, and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLightSpeed_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            double constValue = dba.GetConstant("LightSpeed");
            _currentNumber = constValue.ToString();
            DisplayString(constValue.ToString());
        }

        /// <summary>
        /// Gets the Avogadro number constant from the database, and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNA_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            double constValue = dba.GetConstant("AvogadroNumber");
            _currentNumber = constValue.ToString();
            DisplayString(constValue.ToString());
        }

        /// <summary>
        /// Gets the Pi constant from the database, and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPi_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            double constValue = dba.GetConstant("Pi");
            _currentNumber = constValue.ToString();
            DisplayString(constValue.ToString());
        }

        #endregion

        #region Various input

        /// <summary>
        /// Inserts a comma at the end of the current number. The next numbers entered will be the decimals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdComma_Click(object sender, EventArgs e)
        {
            _currentNumber += ".";
            DisplayString(".");
        }

        /// <summary>
        /// If the current number is positive, puts a "-" sign in front of it. If the number is negative, removes the "-" in front of it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInvert_Click(object sender, EventArgs e)
        {
            if (_currentNumber.ElementAt(0) != '-')
            {
                DisplayString("-", _stringCurrentExpressionStart);
                _currentNumber = "-" + _currentNumber;
            }
            else
            {
                rtxtDisplay.Text = rtxtDisplay.Text.Remove(rtxtDisplay.Text.LastIndexOf('-'), 1);
                _currentNumber = _currentNumber.Remove(_currentNumber.LastIndexOf('-'), 1);
                _stringCurrentExpressionEnd--;
            }
        }

        /// <summary>
        /// Opens a parenthesis and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpenParenthesis_Click(object sender, EventArgs e)
        {
            EndCurrentNumber();
            DisplayString("(");
            _operationList.Add("(");
        }

        /// <summary>
        /// Closes a parenthesis and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCloseParenthesis_Click(object sender, EventArgs e)
        {
            EndCurrentNumber();
            DisplayString(")");
            _operationList.Add(")");
        }

        /// <summary>
        /// Removes the last number/comma from the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDel_Click(object sender, EventArgs e)
        {
            if(_currentNumber != "")
            {
                _currentNumber = _currentNumber.Remove(_currentNumber.Length - 1, 1);
                rtxtDisplay.Text = rtxtDisplay.Text.Remove(rtxtDisplay.Text.Length - 1, 1);
                _stringCurrentExpressionEnd--;
            }
        }

        #endregion

        #region Converting

        /// <summary>
        /// Converts the current number into it's hexadecimal value. If the number is unable to be converted (negative, decimal, non numerical),
        /// an error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConvDecHex_Click(object sender, EventArgs e)
        {
            string hex = "";
            try
            {
                hex = Calculation.ConvDecHex(_currentNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entrer un nombre entier positif pour la conversion");
            }
            DisplayString(" = " + hex);
        }
        /// <summary>
        /// Converts the current number into it's octal value. If the number is unable to be converted (negative, decimal, non numerical),
        /// an error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConvDecOct_Click(object sender, EventArgs e)
        {
            string oct = "";
            try
            {
                oct = Calculation.ConvDecOct(_currentNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entrer un nombre entier positif pour la conversion");
            }
            DisplayString(" = " + oct);
        }

        /// <summary>
        /// Converts the current number into it's binary value. If the number is unable to be converted (negative, decimal, non numerical),
        /// an error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConvDecBin_Click(object sender, EventArgs e)
        {
            string bin = "";
            try
            {
                bin = Calculation.ConvDecBin(_currentNumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez entrer un nombre entier positif pour la conversion");
            }
            DisplayString(" = " + bin);

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
            DisplayString(" + ", _stringCurrentExpressionEnd);
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
            DisplayString(" - ", _stringCurrentExpressionEnd);
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
            DisplayString(" x ", _stringCurrentExpressionEnd);
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
            DisplayString(" / ", _stringCurrentExpressionEnd);
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
            DisplayString("1 / ", _stringCurrentExpressionStart);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " 1/ ");
        }

        /// <summary>
        /// Gives the factorial of a positive number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFactorial_Click(object sender, EventArgs e)
        {
            DisplayString("!", _stringCurrentExpressionEnd);
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
            DisplayString("|", _stringCurrentExpressionStart);
            DisplayString("|", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " abs(");
            _operationList.Add(")");

        }

        /// <summary>
        /// Rounds a number to the nearest integer. (.5 rounds to superior).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRound_Click(object sender, EventArgs e)
        {
            DisplayString("Round(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " round(");
            _operationList.Add(", 0)");
        }

        #endregion

        #region Trigonometry

        /// <summary>
        /// Gives the sine of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSin_Click(object sender, EventArgs e)
        {
            DisplayString("Sin(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " sin(rad(");
            _operationList.Add("))");
            //_ListCurrentExpressionEnd += 2;
        }

        /// <summary>
        /// Gives the cosine of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCos_Click(object sender, EventArgs e)
        {
            DisplayString("Cos(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " cos(rad(");
            _operationList.Add("))");
            //_ListCurrentExpressionEnd += 2;
        }

        /// <summary>
        /// Gives the tangent of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdTan_Click(object sender, EventArgs e)
        {
            DisplayString("Tan(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " tan(rad(");
            _operationList.Add("))");
        }

        /// <summary>
        /// Gives the inverse sine of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInvSin_Click(object sender, EventArgs e)
        {
            DisplayString("invSin(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " deg(asin(");
            _operationList.Add("))");
        }

        /// <summary>
        /// Gives the inverse cosine of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInvCos_Click(object sender, EventArgs e)
        {
            DisplayString("invCos(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " deg(acos(");
            _operationList.Add("))");
        }

        /// <summary>
        /// Gives the inverse tangent of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInvTan_Click(object sender, EventArgs e)
        {
            DisplayString("invTan(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " deg(atan(");
            _operationList.Add("))");
        }

        #endregion

        #region Complex operators

        /// <summary>
        /// Gives the square value of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSquare_Click(object sender, EventArgs e)
        {
            DisplayString("^2", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Add("^2");
        }

        /// <summary>
        /// Gives the square root of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSqrt_Click(object sender, EventArgs e)
        {
            DisplayString("2√", _stringCurrentExpressionStart);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " sqrt(");
            _operationList.Add(")");
        }

        /// <summary>
        /// Allows to raise a number to the power of another number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdExponentiation_Click(object sender, EventArgs e)
        {
            DisplayString("^", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Add("^");
        }

        /// <summary>
        /// Allows to calculate the nth root of a number 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRoot_Click(object sender, EventArgs e)
        {
            DisplayString("√", _stringCurrentExpressionStart);
            EndCurrentNumber();
            _cursorPlace = _stringCurrentExpressionStart;
            _operationList.Add("^(1/");
            addAfter = ")";
        }

        /// <summary>
        /// Gives the exponential value of a number (e to the power of this number)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdExponential_Click(object sender, EventArgs e)
        {
            DisplayString("e^", _stringCurrentExpressionStart);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " exp(");
            _operationList.Add(")");
        }

        /// <summary>
        /// Gives the 10th base logarithm of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLog_Click(object sender, EventArgs e)
        {
            DisplayString("log10(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " log10(");
            _operationList.Add(")");
        }

        /// <summary>
        /// gives the natural logarithm of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLn_Click(object sender, EventArgs e)
        {
            DisplayString("ln(", _stringCurrentExpressionStart);
            DisplayString(")", _stringCurrentExpressionEnd);
            EndCurrentNumber();
            _operationList.Insert(_ListCurrentExpressionStart, " ln(");
            _operationList.Add(")");
        }

        #endregion

        #endregion



        /// <summary>
        /// Clears the displayer and resets the variables used for handling input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClear_Click(object sender, EventArgs e)
        {
            rtxtDisplay.Clear();
            _operationList.Clear();
            _currentNumber = "";
            _cursorPlace = -1;
            _ListCurrentExpressionStart = 0;
            _stringCurrentExpressionStart = 0;
            _stringCurrentExpressionEnd = 1;
        }

        /// <summary>
        /// Ends the current number, then calls the Calculation.Calculate method to solve the operation contained in _operationList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdEqual_Click(object sender, EventArgs e)
        {
            EndCurrentNumber();
            //Gets the result of the operation
            string resultString = Calculation.Solve(_operationList);

            //Rounds the result to the number of decimals wanted if it is a number, and then displays it
            double result = 0;
            if(double.TryParse(resultString, out result))
            {
                result = Math.Round(result, _decimalsAmount);
                DisplayString(" = " + Math.Round(result, _decimalsAmount).ToString());
            }
            else
            {
                DisplayString(" = " + resultString);
            }

            //Resetting or setting some input handling variables
            _stringCurrentExpressionStart = rtxtDisplay.Text.Length + 3;
            _operationList.Clear();
            _operationList.Add(resultString);
            _currentNumber = "";
            _ListCurrentExpressionStart = 0;
        }

        #endregion

        /// <summary>
        /// Ends the current number and stores it in the _operationList
        /// </summary>
        private void EndCurrentNumber()
        {
            //Adds the current number to the operation list and resets it
            if(_currentNumber != "")
            {
                _operationList.Add(_currentNumber);
            }
            _currentNumber = "";

            //If an operator needed to add something at the end of the current number, adds it
            if(addAfter != "")
            {
                _operationList.Add(addAfter);
            }
            addAfter = "";
            _cursorPlace = -1;
        }

        /// <summary>
        /// Displays a string in the rich textbox. Inserts at the end by default, but can be inserted before
        /// </summary>
        /// <param name="stringToDisplay">String that has to be displayed on the displayer</param>
        /// <param name="position">The index in the text where the string has to be inserted</param>
        private void DisplayString(string stringToDisplay, int? position = null)
        {
            //If the cursor is set somewhere other than it's default value (-1), the string is displayed there
            if (_cursorPlace != -1)
            {
                rtxtDisplay.Text = rtxtDisplay.Text.Insert(_cursorPlace, stringToDisplay);
                _cursorPlace += stringToDisplay.Length;
            }

            //Displays the string at the given position
            else
            {
                if (position == null)
                {
                    position = _stringCurrentExpressionEnd;
                }
                if (position == rtxtDisplay.Text.Length + 1)
                {
                    rtxtDisplay.Text += stringToDisplay;
                }
                else
                {
                    rtxtDisplay.Text = rtxtDisplay.Text.Insert((int)position, stringToDisplay);
                }
            } 
            _stringCurrentExpressionEnd += stringToDisplay.Length;
        }

        /// <summary>
        /// Opens the operations history form as a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdHistory_Click(object sender, EventArgs e)
        {
            frmHistory historyForm = new frmHistory();
            historyForm.ShowDialog();
        }


        /// <summary>
        /// Opens the settings form as a dialog window and sets the amount of decimals in case it got changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSettings_Click(object sender, EventArgs e)
        {
            frmSettings settingsForm = new frmSettings();
            settingsForm.ShowDialog();
            DBAccess dba = new DBAccess();
            _decimalsAmount = dba.GetSettingValue("DecimalsAmount");
            lblDecimalsAmount.Text = _decimalsAmount.ToString();
        }

        /// <summary>
        /// Opens the graph displayer form as a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGraphDisplayer_Click(object sender, EventArgs e)
        {
            frmFunctionPlot functionForm = new frmFunctionPlot();
            functionForm.ShowDialog();
        }
    }
}
