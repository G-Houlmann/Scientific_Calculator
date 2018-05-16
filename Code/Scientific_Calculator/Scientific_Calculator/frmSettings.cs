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
        /// <summary>
        /// Constructor
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the new value is valid and between the min and max value, the setting value is changed in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudDecimalsAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// If the new value is valid and between the min and max value, the setting value is changed in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudHistoryAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
