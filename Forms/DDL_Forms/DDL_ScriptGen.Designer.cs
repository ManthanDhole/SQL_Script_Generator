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
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.btn_Drop = new System.Windows.Forms.Button();
            this.ddl_panel_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(168, 35);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(312, 35);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(75, 23);
            this.btn_Alter.TabIndex = 1;
            this.btn_Alter.Text = "Alter";
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // btn_Drop
            // 
            this.btn_Drop.Location = new System.Drawing.Point(448, 35);
            this.btn_Drop.Name = "btn_Drop";
            this.btn_Drop.Size = new System.Drawing.Size(75, 23);
            this.btn_Drop.TabIndex = 2;
            this.btn_Drop.Text = "Drop";
            this.btn_Drop.UseVisualStyleBackColor = true;
            // 
            // ddl_panel_container
            // 
            this.ddl_panel_container.Location = new System.Drawing.Point(3, 82);
            this.ddl_panel_container.Name = "ddl_panel_container";
            this.ddl_panel_container.Size = new System.Drawing.Size(735, 370);
            this.ddl_panel_container.TabIndex = 3;
            // 
            // DDL_ScriptGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.ddl_panel_container);
            this.Controls.Add(this.btn_Drop);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Create);
            this.Name = "DDL_ScriptGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Definition Script Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Create;
        private Button btn_Alter;
        private Button btn_Drop;
        private Panel ddl_panel_container;
    }
}