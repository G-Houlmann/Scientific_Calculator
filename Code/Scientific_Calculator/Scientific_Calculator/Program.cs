using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCalculator());
        }

        /// <summary>
        /// Sets the different settings to their default value if no value has already been given to them in the database
        /// </summary>
        public static void setSettingsToDefault()
        {
            DBAccess dba = new DBAccess();
            string settingName = "decimalsAmount";
            for(int i = 0; i<2; i++)
            {
                //The setting value is equal to 0 if it is not set yet
                if (dba.GetSettingValue(settingName) == 0)
                {
                    int defaultValue = dba.GetDefaultSetting(settingName);
                    dba.UpdateSetting(settingName, defaultValue);
                }
                settingName = "HistoryAmount";
            }
            
            
        }
    }
}
