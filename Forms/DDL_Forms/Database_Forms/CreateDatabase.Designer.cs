namespace SQL_ScriptGenUtility.Forms.DDL_Forms.Database_Forms
{
    partial class CreateDatabase
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
            this.btn_CreateDB = new System.Windows.Forms.Button();
            this.txt_DbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreateDB
            // 
            this.btn_CreateDB.Location = new System.Drawing.Point(107, 152);
            this.btn_CreateDB.Name = "btn_CreateDB";
            this.btn_CreateDB.Size = new System.Drawing.Size(120, 23);
            this.btn_CreateDB.TabIndex = 0;
            this.btn_CreateDB.Text = "Create Database";
            this.btn_CreateDB.UseVisualStyleBackColor = true;
            // 
            // txt_DbName
            // 
            this.txt_DbName.Location = new System.Drawing.Point(78, 108);
            this.txt_DbName.Name = "txt_DbName";
            this.txt_DbName.Size = new System.Drawing.Size(175, 23);
            this.txt_DbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Database Name";
            // 
            // CreateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DbName);
            this.Controls.Add(this.btn_CreateDB);
            this.Name = "CreateDatabase";
            this.Text = "Create Database Script";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CreateDB;
        private TextBox txt_DbName;
        private Label label1;
    }
}