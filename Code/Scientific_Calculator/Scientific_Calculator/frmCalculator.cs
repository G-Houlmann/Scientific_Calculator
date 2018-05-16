using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DisplayChar(".");
        }

        private void cmdInvert_Click(object sender, EventArgs e)
        {

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
        private void cmdPlus_Click(object sender, EventArgs e)
        {
            DisplayChar(" + ");
            EndCurrentNumber();
            _operationList.Add("+");
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            DisplayChar(" - ");
            EndCurrentNumber();
            _operationList.Add("-");
        }

        private void cmdMult_Click(object sender, EventArgs e)
        {
            DisplayChar(" x ");
            EndCurrentNumber();
            _operationList.Add("x");
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            DisplayChar(" / ");
            EndCurrentNumber();
            _operationList.Add("/");
        }

        private void cmdReciprocal_Click(object sender, EventArgs e)
        {
            DisplayChar("1 / ", -1);
            EndCurrentNumber();
            _operationList.Add("1/x");
        }

        private void cmdFactorial_Click(object sender, EventArgs e)
        {

        }

        private void cmdAbsValue_Click(object sender, EventArgs e)
        {

        }

        private void cmdRound_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Trigonometry

        private void cmdSin_Click(object sender, EventArgs e)
        {

        }

        private void cmdCos_Click(object sender, EventArgs e)
        {

        }

        private void cmdTan_Click(object sender, EventArgs e)
        {

        }

        private void cmdInvSin_Click(object sender, EventArgs e)
        {

        }

        private void cmdInvCos_Click(object sender, EventArgs e)
        {

        }

        private void cmdInvTan_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Complex operators

        private void cmdSquare_Click(object sender, EventArgs e)
        {

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
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            EndCurrentNumber();
            Calculation.Calculate(_operationList);
        }

        #endregion

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
