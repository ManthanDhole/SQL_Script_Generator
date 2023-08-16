namespace SQL_ScriptGenUtility.Forms.DDL_Forms
{
    partial class DDL_ScriptGen
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
            this.btn_Database = new System.Windows.Forms.Button();
            this.btn_Table = new System.Windows.Forms.Button();
            this.btn_StoredProcedure = new System.Windows.Forms.Button();
            this.ddl_panel_container = new System.Windows.Forms.Panel();
            this.rb_Create = new System.Windows.Forms.RadioButton();
            this.rb_Alter = new System.Windows.Forms.RadioButton();
            this.rb_Drop = new System.Windows.Forms.RadioButton();
            this.btn_View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Database
            // 
            this.btn_Database.Location = new System.Drawing.Point(85, 84);
            this.btn_Database.Name = "btn_Database";
            this.btn_Database.Size = new System.Drawing.Size(75, 23);
            this.btn_Database.TabIndex = 0;
            this.btn_Database.Text = "Database";
            this.btn_Database.UseVisualStyleBackColor = true;
            // 
            // btn_Table
            // 
            this.btn_Table.Location = new System.Drawing.Point(229, 84);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(75, 23);
            this.btn_Table.TabIndex = 1;
            this.btn_Table.Text = "Table";
            this.btn_Table.UseVisualStyleBackColor = true;
            // 
            // btn_StoredProcedure
            // 
            this.btn_StoredProcedure.Location = new System.Drawing.Point(365, 84);
            this.btn_StoredProcedure.Name = "btn_StoredProcedure";
            this.btn_StoredProcedure.Size = new System.Drawing.Size(131, 23);
            this.btn_StoredProcedure.TabIndex = 2;
            this.btn_StoredProcedure.Text = "Stored Procedure";
            this.btn_StoredProcedure.UseVisualStyleBackColor = true;
            // 
            // ddl_panel_container
            // 
            this.ddl_panel_container.Location = new System.Drawing.Point(3, 146);
            this.ddl_panel_container.Name = "ddl_panel_container";
            this.ddl_panel_container.Size = new System.Drawing.Size(735, 306);
            this.ddl_panel_container.TabIndex = 3;
            // 
            // rb_Create
            // 
            this.rb_Create.AutoSize = true;
            this.rb_Create.Location = new System.Drawing.Point(239, 35);
            this.rb_Create.Name = "rb_Create";
            this.rb_Create.Size = new System.Drawing.Size(59, 19);
            this.rb_Create.TabIndex = 4;
            this.rb_Create.TabStop = true;
            this.rb_Create.Text = "Create";
            this.rb_Create.UseVisualStyleBackColor = true;
            // 
            // rb_Alter
            // 
            this.rb_Alter.AutoSize = true;
            this.rb_Alter.Location = new System.Drawing.Point(335, 35);
            this.rb_Alter.Name = "rb_Alter";
            this.rb_Alter.Size = new System.Drawing.Size(50, 19);
            this.rb_Alter.TabIndex = 5;
            this.rb_Alter.TabStop = true;
            this.rb_Alter.Text = "Alter";
            this.rb_Alter.UseVisualStyleBackColor = true;
            // 
            // rb_Drop
            // 
            this.rb_Drop.AutoSize = true;
            this.rb_Drop.Location = new System.Drawing.Point(425, 35);
            this.rb_Drop.Name = "rb_Drop";
            this.rb_Drop.Size = new System.Drawing.Size(51, 19);
            this.rb_Drop.TabIndex = 6;
            this.rb_Drop.TabStop = true;
            this.rb_Drop.Text = "Drop";
            this.rb_Drop.UseVisualStyleBackColor = true;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(542, 84);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 7;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // DDL_ScriptGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.rb_Drop);
            this.Controls.Add(this.rb_Alter);
            this.Controls.Add(this.rb_Create);
            this.Controls.Add(this.ddl_panel_container);
            this.Controls.Add(this.btn_StoredProcedure);
            this.Controls.Add(this.btn_Table);
            this.Controls.Add(this.btn_Database);
            this.Name = "DDL_ScriptGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Definition Script Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Database;
        private Button btn_Table;
        private Button btn_StoredProcedure;
        private Panel ddl_panel_container;
        private RadioButton rb_Create;
        private RadioButton rb_Alter;
        private RadioButton rb_Drop;
        private Button btn_View;
    }
}