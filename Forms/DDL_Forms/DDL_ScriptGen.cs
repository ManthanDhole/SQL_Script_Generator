using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_ScriptGenUtility.CommonHelperCode;
using SQL_ScriptGenUtility.Forms.DDL_Forms.Database_Forms;
using SQL_ScriptGenUtility.Forms.DDL_Forms.Table_Forms;

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
                MessageBox.Show("Select an action to perform from the radio buttons above.", "No Radio Button selected", MessageBoxButtons.OK);

            //Clear the panel component controls
            OpenComponent_inPanel.ClearControlsFromPanel(ddl_panel_container);

            switch (action)
            {
                case "Create":
                    CreateDatabase creatDb = new CreateDatabase();
                    creatDb.TopLevel = false;
                    ddl_panel_container.Controls.Add(creatDb);
                    creatDb.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    creatDb.Dock = DockStyle.Fill;
                    creatDb.Show();
                    break;
                case "Alter":
                    break;
                case "Drop":
                    break;
                default:
                    break;
            }
        }

        private void btn_Table_Click(object sender, EventArgs e)
        {
            string action = string.Empty;

            if (rb_Create.Checked)
                action = "Create";
            else if (rb_Alter.Checked)
                action = "Alter";
            else if (rb_Drop.Checked)
                action = "Drop";
            else
                MessageBox.Show("Select an action to perform from the radio buttons above.", "No Radio Button selected", MessageBoxButtons.OK);

            //Clear the panel component controls
            OpenComponent_inPanel.ClearControlsFromPanel(ddl_panel_container);

            switch (action)
            {
                case "Create":
                    CreateTable creatTbl = new CreateTable();
                    creatTbl.TopLevel = false;
                    ddl_panel_container.Controls.Add(creatTbl);
                    creatTbl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    creatTbl.Dock = DockStyle.Fill;
                    creatTbl.Show();
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
