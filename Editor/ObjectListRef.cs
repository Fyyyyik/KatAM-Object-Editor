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
    public partial class ObjectListRef : Form
    {
        MainForm mainFormInstance;

        public ObjectListRef(MainForm mainForm)
        {
            InitializeComponent();

            mainFormInstance = mainForm;
        }

        private void ObjectListRef_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            foreach (string obj in mainFormInstance.listItems)
            {
                listBoxObjects.Items.Add(obj);
            }
        }
    }
}
