namespace SQL_ScriptGenUtility.Forms.DDL_Forms.Table_Forms
{
    partial class CreateTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.btn_AddColumn = new System.Windows.Forms.Button();
            this.panel_AddColumns = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ColumnName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_DataType = new System.Windows.Forms.ComboBox();
            this.chk_PrimaryKey = new System.Windows.Forms.CheckBox();
            this.chk_NotNull = new System.Windows.Forms.CheckBox();
            this.chk_Unique = new System.Windows.Forms.CheckBox();
            this.chk_ForeignKey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VarcharLength = new System.Windows.Forms.TextBox();
            this.panel_AddColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(224, 70);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(166, 23);
            this.txt_TableName.TabIndex = 1;
            // 
            // btn_AddColumn
            // 
            this.btn_AddColumn.Location = new System.Drawing.Point(248, 167);
            this.btn_AddColumn.Name = "btn_AddColumn";
            this.btn_AddColumn.Size = new System.Drawing.Size(142, 23);
            this.btn_AddColumn.TabIndex = 2;
            this.btn_AddColumn.Text = "Add Column";
            this.btn_AddColumn.UseVisualStyleBackColor = true;
            this.btn_AddColumn.Click += new System.EventHandler(this.btn_AddColumn_Click);
            // 
            // panel_AddColumns
            // 
            this.panel_AddColumns.Controls.Add(this.txt_VarcharLength);
            this.panel_AddColumns.Controls.Add(this.label4);
            this.panel_AddColumns.Controls.Add(this.chk_ForeignKey);
            this.panel_AddColumns.Controls.Add(this.btn_AddColumn);
            this.panel_AddColumns.Controls.Add(this.chk_Unique);
            this.panel_AddColumns.Controls.Add(this.chk_NotNull);
            this.panel_AddColumns.Controls.Add(this.chk_PrimaryKey);
            this.panel_AddColumns.Controls.Add(this.cmb_DataType);
            this.panel_AddColumns.Controls.Add(this.label3);
            this.panel_AddColumns.Controls.Add(this.label2);
            this.panel_AddColumns.Controls.Add(this.txt_ColumnName);
            this.panel_AddColumns.Location = new System.Drawing.Point(52, 119);
            this.panel_AddColumns.Name = "panel_AddColumns";
            this.panel_AddColumns.Size = new System.Drawing.Size(636, 276);
            this.panel_AddColumns.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column Name";
            // 
            // txt_ColumnName
            // 
            this.txt_ColumnName.Location = new System.Drawing.Point(22, 72);
            this.txt_ColumnName.Name = "txt_ColumnName";
            this.txt_ColumnName.Size = new System.Drawing.Size(137, 23);
            this.txt_ColumnName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Type";
            // 
            // cmb_DataType
            // 
            this.cmb_DataType.FormattingEnabled = true;
            this.cmb_DataType.Items.AddRange(new object[] {
            "Integer",
            "Float",
            "Varchar",
            "Boolean",
            "Date Time",
            "Timestamp",
            "NVarchar"});
            this.cmb_DataType.Location = new System.Drawing.Point(165, 72);
            this.cmb_DataType.Name = "cmb_DataType";
            this.cmb_DataType.Size = new System.Drawing.Size(121, 23);
            this.cmb_DataType.TabIndex = 7;
            // 
            // chk_PrimaryKey
            // 
            this.chk_PrimaryKey.AutoSize = true;
            this.chk_PrimaryKey.Location = new System.Drawing.Point(292, 74);
            this.chk_PrimaryKey.Name = "chk_PrimaryKey";
            this.chk_PrimaryKey.Size = new System.Drawing.Size(89, 19);
            this.chk_PrimaryKey.TabIndex = 8;
            this.chk_PrimaryKey.Text = "Primary Key";
            this.chk_PrimaryKey.UseVisualStyleBackColor = true;
            // 
            // chk_NotNull
            // 
            this.chk_NotNull.AutoSize = true;
            this.chk_NotNull.Location = new System.Drawing.Point(385, 75);
            this.chk_NotNull.Name = "chk_NotNull";
            this.chk_NotNull.Size = new System.Drawing.Size(71, 19);
            this.chk_NotNull.TabIndex = 9;
            this.chk_NotNull.Text = "Not Null";
            this.chk_NotNull.UseVisualStyleBackColor = true;
            // 
            // chk_Unique
            // 
            this.chk_Unique.AutoSize = true;
            this.chk_Unique.Location = new System.Drawing.Point(462, 74);
            this.chk_Unique.Name = "chk_Unique";
            this.chk_Unique.Size = new System.Drawing.Size(64, 19);
            this.chk_Unique.TabIndex = 10;
            this.chk_Unique.Text = "Unique";
            this.chk_Unique.UseVisualStyleBackColor = true;
            // 
            // chk_ForeignKey
            // 
            this.chk_ForeignKey.AutoSize = true;
            this.chk_ForeignKey.Location = new System.Drawing.Point(532, 74);
            this.chk_ForeignKey.Name = "chk_ForeignKey";
            this.chk_ForeignKey.Size = new System.Drawing.Size(88, 19);
            this.chk_ForeignKey.TabIndex = 11;
            this.chk_ForeignKey.Text = "Foreign Key";
            this.chk_ForeignKey.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Length";
            // 
            // txt_VarcharLength
            // 
            this.txt_VarcharLength.Location = new System.Drawing.Point(217, 110);
            this.txt_VarcharLength.Name = "txt_VarcharLength";
            this.txt_VarcharLength.Size = new System.Drawing.Size(69, 23);
            this.txt_VarcharLength.TabIndex = 13;
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_AddColumns);
            this.Controls.Add(this.txt_TableName);
            this.Controls.Add(this.label1);
            this.Name = "CreateTable";
            this.Text = "CreateTable";
            this.panel_AddColumns.ResumeLayout(false);
            this.panel_AddColumns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_TableName;
        private Button btn_AddColumn;
        private Panel panel_AddColumns;
        private TextBox txt_VarcharLength;
        private Label label4;
        private CheckBox chk_ForeignKey;
        private CheckBox chk_Unique;
        private CheckBox chk_NotNull;
        private CheckBox chk_PrimaryKey;
        private ComboBox cmb_DataType;
        private Label label3;
        private Label label2;
        private TextBox txt_ColumnName;
    }
}