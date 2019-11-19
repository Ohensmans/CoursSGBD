namespace _2019._10._17_MDI
{
    partial class FormClasseUpdate
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
            this.cb_ClasseExistante = new System.Windows.Forms.ComboBox();
            this.l_LibAChanger = new System.Windows.Forms.Label();
            this.l_NewLibelle = new System.Windows.Forms.Label();
            this.tb_NewLibelle = new System.Windows.Forms.TextBox();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_ClasseExistante
            // 
            this.cb_ClasseExistante.FormattingEnabled = true;
            this.cb_ClasseExistante.Location = new System.Drawing.Point(134, 59);
            this.cb_ClasseExistante.Name = "cb_ClasseExistante";
            this.cb_ClasseExistante.Size = new System.Drawing.Size(121, 21);
            this.cb_ClasseExistante.TabIndex = 0;
            // 
            // l_LibAChanger
            // 
            this.l_LibAChanger.AutoSize = true;
            this.l_LibAChanger.Location = new System.Drawing.Point(13, 62);
            this.l_LibAChanger.Name = "l_LibAChanger";
            this.l_LibAChanger.Size = new System.Drawing.Size(88, 13);
            this.l_LibAChanger.TabIndex = 1;
            this.l_LibAChanger.Text = "Libellé à changer";
            // 
            // l_NewLibelle
            // 
            this.l_NewLibelle.AutoSize = true;
            this.l_NewLibelle.Location = new System.Drawing.Point(16, 112);
            this.l_NewLibelle.Name = "l_NewLibelle";
            this.l_NewLibelle.Size = new System.Drawing.Size(80, 13);
            this.l_NewLibelle.TabIndex = 2;
            this.l_NewLibelle.Text = "Nouveau libellé";
            // 
            // tb_NewLibelle
            // 
            this.tb_NewLibelle.Location = new System.Drawing.Point(134, 109);
            this.tb_NewLibelle.Name = "tb_NewLibelle";
            this.tb_NewLibelle.Size = new System.Drawing.Size(121, 20);
            this.tb_NewLibelle.TabIndex = 3;
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(16, 164);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(98, 23);
            this.bt_Update.TabIndex = 4;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(157, 164);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(98, 23);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormClasseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 201);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.tb_NewLibelle);
            this.Controls.Add(this.l_NewLibelle);
            this.Controls.Add(this.l_LibAChanger);
            this.Controls.Add(this.cb_ClasseExistante);
            this.Name = "FormClasseUpdate";
            this.Text = "Mise à jour de Classe";
            this.Load += new System.EventHandler(this.FormClasseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ClasseExistante;
        private System.Windows.Forms.Label l_LibAChanger;
        private System.Windows.Forms.Label l_NewLibelle;
        private System.Windows.Forms.TextBox tb_NewLibelle;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Close;
    }
}