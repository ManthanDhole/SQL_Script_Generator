namespace SQL_ScriptGenUtility.Forms
{
    partial class SQL_ScriptGenForm
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
            this.btn_DQL = new System.Windows.Forms.Button();
            this.btn_DML = new System.Windows.Forms.Button();
            this.btn_DDL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DQL
            // 
            this.btn_DQL.Location = new System.Drawing.Point(89, 177);
            this.btn_DQL.Name = "btn_DQL";
            this.btn_DQL.Size = new System.Drawing.Size(117, 57);
            this.btn_DQL.TabIndex = 5;
            this.btn_DQL.Text = "DQL";
            this.btn_DQL.UseVisualStyleBackColor = true;
            this.btn_DQL.Click += new System.EventHandler(this.btn_DQL_Click);
            // 
            // btn_DML
            // 
            this.btn_DML.Location = new System.Drawing.Point(89, 114);
            this.btn_DML.Name = "btn_DML";
            this.btn_DML.Size = new System.Drawing.Size(117, 57);
            this.btn_DML.TabIndex = 4;
            this.btn_DML.Text = "DML";
            this.btn_DML.UseVisualStyleBackColor = true;
            this.btn_DML.Click += new System.EventHandler(this.btn_DML_Click);
            // 
            // btn_DDL
            // 
            this.btn_DDL.Location = new System.Drawing.Point(89, 51);
            this.btn_DDL.Name = "btn_DDL";
            this.btn_DDL.Size = new System.Drawing.Size(117, 57);
            this.btn_DDL.TabIndex = 3;
            this.btn_DDL.Text = "DDL";
            this.btn_DDL.UseVisualStyleBackColor = true;
            this.btn_DDL.Click += new System.EventHandler(this.btn_DDL_Click);
            // 
            // SQL_ScriptGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 281);
            this.Controls.Add(this.btn_DQL);
            this.Controls.Add(this.btn_DML);
            this.Controls.Add(this.btn_DDL);
            this.Name = "SQL_ScriptGenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Script Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_DQL;
        private Button btn_DML;
        private Button btn_DDL;
    }
}