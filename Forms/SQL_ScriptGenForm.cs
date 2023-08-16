using SQL_ScriptGenUtility.Forms.DDL_Forms;
using SQL_ScriptGenUtility.Forms.DML_Forms;
using SQL_ScriptGenUtility.Forms.DQL_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_ScriptGenUtility.Forms
{
    public partial class SQL_ScriptGenForm : Form
    {
        public SQL_ScriptGenForm()
        {
            InitializeComponent();
        }

        private void btn_DDL_Click(object sender, EventArgs e)
        {
            DDL_ScriptGen ddl = new DDL_ScriptGen();
            ddl.Show();
        }

        private void btn_DML_Click(object sender, EventArgs e)
        {
            DML_ScriptGen dml = new DML_ScriptGen();
            dml.Show();
        }

        private void btn_DQL_Click(object sender, EventArgs e)
        {
            DQL_ScriptGen dql = new DQL_ScriptGen();
            dql.Show();
        }
    }
}
