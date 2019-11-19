namespace _2019._10._17_MDI
{
    partial class FormStudentsUpdate
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
            this.l_OldStudents = new System.Windows.Forms.Label();
            this.cb_Students = new System.Windows.Forms.ComboBox();
            this.l_NewNom = new System.Windows.Forms.Label();
            this.l_NewPrenom = new System.Windows.Forms.Label();
            this.tb_NewName = new System.Windows.Forms.TextBox();
            this.tb_NewPrenom = new System.Windows.Forms.TextBox();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_OldStudents
            // 
            this.l_OldStudents.AutoSize = true;
            this.l_OldStudents.Location = new System.Drawing.Point(12, 48);
            this.l_OldStudents.Name = "l_OldStudents";
            this.l_OldStudents.Size = new System.Drawing.Size(92, 13);
            this.l_OldStudents.TabIndex = 0;
            this.l_OldStudents.Text = "Etudiant à modifer";
            // 
            // cb_Students
            // 
            this.cb_Students.FormattingEnabled = true;
            this.cb_Students.Location = new System.Drawing.Point(214, 45);
            this.cb_Students.Name = "cb_Students";
            this.cb_Students.Size = new System.Drawing.Size(228, 21);
            this.cb_Students.TabIndex = 1;
            this.cb_Students.SelectedIndexChanged += new System.EventHandler(this.cb_Students_SelectedIndexChanged);
            // 
            // l_NewNom
            // 
            this.l_NewNom.AutoSize = true;
            this.l_NewNom.Location = new System.Drawing.Point(15, 103);
            this.l_NewNom.Name = "l_NewNom";
            this.l_NewNom.Size = new System.Drawing.Size(74, 13);
            this.l_NewNom.TabIndex = 2;
            this.l_NewNom.Text = "Nouveau nom";
            // 
            // l_NewPrenom
            // 
            this.l_NewPrenom.AutoSize = true;
            this.l_NewPrenom.Location = new System.Drawing.Point(235, 103);
            this.l_NewPrenom.Name = "l_NewPrenom";
            this.l_NewPrenom.Size = new System.Drawing.Size(89, 13);
            this.l_NewPrenom.TabIndex = 3;
            this.l_NewPrenom.Text = "Nouveau prénom";
            // 
            // tb_NewName
            // 
            this.tb_NewName.Location = new System.Drawing.Point(109, 100);
            this.tb_NewName.Name = "tb_NewName";
            this.tb_NewName.Size = new System.Drawing.Size(100, 20);
            this.tb_NewName.TabIndex = 4;
            // 
            // tb_NewPrenom
            // 
            this.tb_NewPrenom.Location = new System.Drawing.Point(342, 100);
            this.tb_NewPrenom.Name = "tb_NewPrenom";
            this.tb_NewPrenom.Size = new System.Drawing.Size(100, 20);
            this.tb_NewPrenom.TabIndex = 5;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(15, 142);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(129, 23);
            this.bt_Update.TabIndex = 6;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(313, 142);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(129, 23);
            this.bt_Close.TabIndex = 7;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormStudentsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 191);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.tb_NewPrenom);
            this.Controls.Add(this.tb_NewName);
            this.Controls.Add(this.l_NewPrenom);
            this.Controls.Add(this.l_NewNom);
            this.Controls.Add(this.cb_Students);
            this.Controls.Add(this.l_OldStudents);
            this.Name = "FormStudentsUpdate";
            this.Text = "Modifier un étudiant";
            this.Load += new System.EventHandler(this.FormStudentsUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_OldStudents;
        private System.Windows.Forms.ComboBox cb_Students;
        private System.Windows.Forms.Label l_NewNom;
        private System.Windows.Forms.Label l_NewPrenom;
        private System.Windows.Forms.TextBox tb_NewName;
        private System.Windows.Forms.TextBox tb_NewPrenom;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Close;
    }
}