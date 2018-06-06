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
    /// Form that allows the user to change some application settings
    /// </summary>
    public partial class frmSettings : Form
    {
        int[] _decimalsAmountMinMax = new int[2];
        int[] _historyAmountMinMax = new int[2];

        private int _decimalsAmount;
        private int _historyAmount;



        /// <summary>
        /// Constructor. Retrives the settings values from the database.
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();
            getSettingsValue();
            nudDecimalsAmount.Minimum = _decimalsAmountMinMax[0];
            nudDecimalsAmount.Maximum = _decimalsAmountMinMax[1];
            nudHistoryAmount.Minimum = _historyAmountMinMax[0];
            nudHistoryAmount.Maximum = _historyAmountMinMax[1];
        }

        /// <summary>
        /// Retrieving the settings min, max and actual values
        /// </summary>
        private void getSettingsValue()
        {
            DBAccess dba = new DBAccess();
            _decimalsAmount = dba.GetSettingValue("DecimalsAmount");
            _historyAmount = dba.GetSettingValue("HistoryAmount");
            _decimalsAmountMinMax = dba.GetSettingMinMax("DecimalsAmount");
            _historyAmountMinMax = dba.GetSettingMinMax("HistoryAmount");
            nudDecimalsAmount.Value = _decimalsAmount;
            nudHistoryAmount.Value = _historyAmount;
        }

        /// <summary>
        /// If the new value is valid and between the min and max value, the setting value is changed in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudDecimalsAmount_ValueChanged(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            dba.UpdateSetting("DecimalsAmount", (int)nudDecimalsAmount.Value);
        }

        /// <summary>
        /// If the new value is valid and between the min and max value, the setting value is changed in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudHistoryAmount_ValueChanged(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            dba.UpdateSetting("HistoryAmount", (int)nudHistoryAmount.Value);
        }
    }
}
