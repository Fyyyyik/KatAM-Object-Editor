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
    public partial class VersionSelect : Form
    {
        MainForm mainFormInstance;

        public VersionSelect(MainForm mainForm)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
        }

        private void VersionSelect_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_japanese_Click(object sender, EventArgs e)
        {
            mainFormInstance.openedFileVersion = "Japanese";
            this.Close();
        }

        private void btn_usa_Click(object sender, EventArgs e)
        {
            mainFormInstance.openedFileVersion = "American";
            this.Close();
        }

        private void btn_eu_Click(object sender, EventArgs e)
        {
            mainFormInstance.openedFileVersion = "Europe";
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainFormInstance.openedFilePath = mainFormInstance.openedFilePathC;
            this.Close();
        }
    }
}
