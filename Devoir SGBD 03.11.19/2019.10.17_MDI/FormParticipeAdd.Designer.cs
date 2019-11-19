namespace _2019._10._17_MDI
{
    partial class FormParticipeAdd
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
            this.cb_Etudiant = new System.Windows.Forms.ComboBox();
            this.l_Classe = new System.Windows.Forms.Label();
            this.cb_Classe = new System.Windows.Forms.ComboBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Étudiant";
            // 
            // cb_Etudiant
            // 
            this.cb_Etudiant.FormattingEnabled = true;
            this.cb_Etudiant.Location = new System.Drawing.Point(87, 42);
            this.cb_Etudiant.Name = "cb_Etudiant";
            this.cb_Etudiant.Size = new System.Drawing.Size(138, 21);
            this.cb_Etudiant.TabIndex = 1;
            // 
            // l_Classe
            // 
            this.l_Classe.AutoSize = true;
            this.l_Classe.Location = new System.Drawing.Point(255, 45);
            this.l_Classe.Name = "l_Classe";
            this.l_Classe.Size = new System.Drawing.Size(38, 13);
            this.l_Classe.TabIndex = 2;
            this.l_Classe.Text = "Classe";
            // 
            // cb_Classe
            // 
            this.cb_Classe.FormattingEnabled = true;
            this.cb_Classe.Location = new System.Drawing.Point(315, 42);
            this.cb_Classe.Name = "cb_Classe";
            this.cb_Classe.Size = new System.Drawing.Size(138, 21);
            this.cb_Classe.TabIndex = 3;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(58, 87);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(139, 23);
            this.bt_Add.TabIndex = 4;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(277, 87);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(139, 23);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormParticipeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 135);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.cb_Classe);
            this.Controls.Add(this.l_Classe);
            this.Controls.Add(this.cb_Etudiant);
            this.Controls.Add(this.label1);
            this.Name = "FormParticipeAdd";
            this.Text = "Ajouter Participations";
            this.Load += new System.EventHandler(this.FormParticipeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Etudiant;
        private System.Windows.Forms.Label l_Classe;
        private System.Windows.Forms.ComboBox cb_Classe;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Close;
    }
}