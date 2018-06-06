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
    /// Form that displays the operations history on a listbox
    /// </summary>
    public partial class frmHistory : Form
    {
        /// <summary>
        /// Constructor. Calls the DisplayHistory method when finished.
        /// </summary>
        public frmHistory()
        {
            InitializeComponent();
            DisplayHistory();
        }

        /// <summary>
        /// Displays the operations history retrieved from the database
        /// </summary>
        private void DisplayHistory()
        {
            DBAccess dba = new DBAccess();
            List<string> lstLog = new List<string>();

            //Retrieving the amount of entries to display
            int operationsAmount = dba.GetSettingValue("HistoryAmount");
            lblHistoryAmount.Text = operationsAmount.ToString();

            //The "var" type is used here because List<string[]> caused an error
            var lstDatas = dba.GetOperationHistory(operationsAmount);
            //Retrieving
            int counter = 0;
            string logString;
            foreach (string opString in lstDatas.ElementAt(1))
            {
                logString = lstDatas.ElementAt(0)[counter] + "   " + opString;
                lstLog.Add(logString);
                counter++;
            }

            //Displaying the items in the listbox
            foreach (string s in lstLog)
            {
                lstHistory.Items.Add(s);
            }
        }
    }
}
