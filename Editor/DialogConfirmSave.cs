using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatAM_Object_Editor.Editor
{
    public partial class DialogConfirmSave : Form
    {
        MainForm mainFormInstance;

        public DialogConfirmSave(MainForm mainForm)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            mainFormInstance.hasCancelledSave = false;
            WillShowThisAgain();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            mainFormInstance.hasCancelledSave = true;
            WillShowThisAgain();
            this.Close();
        }

        void WillShowThisAgain()
        {
            if (checkBoxShowAgain.Checked)
            {
                ConfigIniFile config = new ConfigIniFile(mainFormInstance.iniFilePath);
                config.WriteValue("Misc", "ShowWarning", "false");
            }
        }
    }
}
