namespace _2019._10._17_MDI
{
    partial class FormStudentsAdd
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
            this.l_NewName = new System.Windows.Forms.Label();
            this.l_NewPrenom = new System.Windows.Forms.Label();
            this.tb_NewNom = new System.Windows.Forms.TextBox();
            this.tb_NewPrenom = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_NewName
            // 
            this.l_NewName.AutoSize = true;
            this.l_NewName.Location = new System.Drawing.Point(27, 55);
            this.l_NewName.Name = "l_NewName";
            this.l_NewName.Size = new System.Drawing.Size(76, 13);
            this.l_NewName.TabIndex = 0;
            this.l_NewName.Text = "Nouveau Nom";
            // 
            // l_NewPrenom
            // 
            this.l_NewPrenom.AutoSize = true;
            this.l_NewPrenom.Location = new System.Drawing.Point(27, 104);
            this.l_NewPrenom.Name = "l_NewPrenom";
            this.l_NewPrenom.Size = new System.Drawing.Size(90, 13);
            this.l_NewPrenom.TabIndex = 1;
            this.l_NewPrenom.Text = "Nouveau Prénom";
            // 
            // tb_NewNom
            // 
            this.tb_NewNom.Location = new System.Drawing.Point(165, 52);
            this.tb_NewNom.Name = "tb_NewNom";
            this.tb_NewNom.Size = new System.Drawing.Size(131, 20);
            this.tb_NewNom.TabIndex = 2;
            // 
            // tb_NewPrenom
            // 
            this.tb_NewPrenom.Location = new System.Drawing.Point(165, 101);
            this.tb_NewPrenom.Name = "tb_NewPrenom";
            this.tb_NewPrenom.Size = new System.Drawing.Size(131, 20);
            this.tb_NewPrenom.TabIndex = 3;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(30, 154);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(99, 23);
            this.bt_Add.TabIndex = 4;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(179, 154);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(99, 23);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormStudentsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 189);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_NewPrenom);
            this.Controls.Add(this.tb_NewNom);
            this.Controls.Add(this.l_NewPrenom);
            this.Controls.Add(this.l_NewName);
            this.Name = "FormStudentsAdd";
            this.Text = "Ajouter un étudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_NewName;
        private System.Windows.Forms.Label l_NewPrenom;
        private System.Windows.Forms.TextBox tb_NewNom;
        private System.Windows.Forms.TextBox tb_NewPrenom;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Close;
    }
}