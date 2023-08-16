using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ScriptGenUtility.Forms.DDL_Forms
{
    public partial class DDL_ScriptGen : Form
    {
        public DDL_ScriptGen()
        {
            InitializeComponent();
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            string action = string.Empty;

            if (rb_Create.Checked)
                action = "Create";
            else if (rb_Alter.Checked)
                action = "Alter";
            else if (rb_Drop.Checked)
                action = "Drop";
            else
                action = "Select an action to perform";

            switch (action)
            {
                case "Create":
                    break;
                case "Alter":
                    break;
                case "Drop":
                    break;
                default:
                    break;
            }
        }
    }
}
