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
        }

        /// <summary>
        /// Displays the operations history retrieved from the database
        /// </summary>
        private void DisplayHistory()
        {

        }
    }
}
