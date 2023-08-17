using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SQL_ScriptGenUtility.Constants.TableConstants.CreateTable;

namespace SQL_ScriptGenUtility.Forms.DDL_Forms.Table_Forms
{
    public partial class CreateTable : Form
    {
        private StringBuilder columns = new StringBuilder();
        private CreateTableConstants createTable = new CreateTableConstants();

        private Columns col = new Columns();
        
        public CreateTable()
        {
            InitializeComponent();
        }

        private void btn_AddColumn_Click(object sender, EventArgs e)
        {
            createTable.tableName = txt_TableName.Text;

            if (!String.IsNullOrEmpty(createTable.tableName))
            {
                col.columnName = txt_ColumnName.Text;
                col.columnDataType = cmb_DataType.Text;
                col.isNotNull = chk_NotNull.Checked;
                col.isUnique = chk_Unique.Checked;
                col.isPrimaryKey = chk_PrimaryKey.Checked;
                col.isForeignKey = chk_ForeignKey.Checked;
                
                createTable.columns.Add(col);
            }
            else
            {
                MessageBox.Show("Please enter the Table Name", "Table Name Empty", MessageBoxButtons.OK);
            }
        }
    }
}
