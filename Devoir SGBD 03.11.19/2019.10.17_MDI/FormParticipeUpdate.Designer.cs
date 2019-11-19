namespace _2019._10._17_MDI
{
    partial class FormParticipeUpdate
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
            this.cb_Etudiant = new System.Windows.Forms.ComboBox();
            this.l_SelectionEtudiant = new System.Windows.Forms.Label();
            this.l_titreClasse = new System.Windows.Forms.Label();
            this.l_NomClasseEnCours = new System.Windows.Forms.Label();
            this.l_titreNouvelleClasse = new System.Windows.Forms.Label();
            this.cb_Classe = new System.Windows.Forms.ComboBox();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Etudiant
            // 
            this.cb_Etudiant.FormattingEnabled = true;
            this.cb_Etudiant.Location = new System.Drawing.Point(29, 80);
            this.cb_Etudiant.Name = "cb_Etudiant";
            this.cb_Etudiant.Size = new System.Drawing.Size(160, 21);
            this.cb_Etudiant.TabIndex = 1;
            this.cb_Etudiant.SelectedIndexChanged += new System.EventHandler(this.cb_Etudiant_SelectedIndexChanged);
            // 
            // l_SelectionEtudiant
            // 
            this.l_SelectionEtudiant.AutoSize = true;
            this.l_SelectionEtudiant.Location = new System.Drawing.Point(29, 51);
            this.l_SelectionEtudiant.Name = "l_SelectionEtudiant";
            this.l_SelectionEtudiant.Size = new System.Drawing.Size(101, 13);
            this.l_SelectionEtudiant.TabIndex = 4;
            this.l_SelectionEtudiant.Text = "Choissisez l\'étudiant";
            // 
            // l_titreClasse
            // 
            this.l_titreClasse.AutoSize = true;
            this.l_titreClasse.Location = new System.Drawing.Point(225, 51);
            this.l_titreClasse.Name = "l_titreClasse";
            this.l_titreClasse.Size = new System.Drawing.Size(82, 13);
            this.l_titreClasse.TabIndex = 5;
            this.l_titreClasse.Text = "Classe en cours";
            // 
            // l_NomClasseEnCours
            // 
            this.l_NomClasseEnCours.AutoSize = true;
            this.l_NomClasseEnCours.Location = new System.Drawing.Point(225, 83);
            this.l_NomClasseEnCours.Name = "l_NomClasseEnCours";
            this.l_NomClasseEnCours.Size = new System.Drawing.Size(0, 13);
            this.l_NomClasseEnCours.TabIndex = 6;
            // 
            // l_titreNouvelleClasse
            // 
            this.l_titreNouvelleClasse.AutoSize = true;
            this.l_titreNouvelleClasse.Location = new System.Drawing.Point(411, 51);
            this.l_titreNouvelleClasse.Name = "l_titreNouvelleClasse";
            this.l_titreNouvelleClasse.Size = new System.Drawing.Size(83, 13);
            this.l_titreNouvelleClasse.TabIndex = 7;
            this.l_titreNouvelleClasse.Text = "Nouvelle Classe";
            // 
            // cb_Classe
            // 
            this.cb_Classe.FormattingEnabled = true;
            this.cb_Classe.Location = new System.Drawing.Point(414, 80);
            this.cb_Classe.Name = "cb_Classe";
            this.cb_Classe.Size = new System.Drawing.Size(160, 21);
            this.cb_Classe.TabIndex = 8;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(73, 124);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(75, 23);
            this.bt_Update.TabIndex = 9;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(435, 124);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 23);
            this.bt_Close.TabIndex = 10;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormParticipeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 166);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.cb_Classe);
            this.Controls.Add(this.l_titreNouvelleClasse);
            this.Controls.Add(this.l_NomClasseEnCours);
            this.Controls.Add(this.l_titreClasse);
            this.Controls.Add(this.l_SelectionEtudiant);
            this.Controls.Add(this.cb_Etudiant);
            this.Name = "FormParticipeUpdate";
            this.Text = "Mise à jour des inscriptions";
            this.Load += new System.EventHandler(this.FormParticipeUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Etudiant;
        private System.Windows.Forms.Label l_SelectionEtudiant;
        private System.Windows.Forms.Label l_titreClasse;
        private System.Windows.Forms.Label l_NomClasseEnCours;
        private System.Windows.Forms.Label l_titreNouvelleClasse;
        private System.Windows.Forms.ComboBox cb_Classe;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Close;
    }
}