namespace _2019._10._17_MDI
{
    partial class FormClasseAdd
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
            this.l_NewLibelle = new System.Windows.Forms.Label();
            this.tb_NewLibelle = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_NewLibelle
            // 
            this.l_NewLibelle.AutoSize = true;
            this.l_NewLibelle.Location = new System.Drawing.Point(12, 37);
            this.l_NewLibelle.Name = "l_NewLibelle";
            this.l_NewLibelle.Size = new System.Drawing.Size(139, 13);
            this.l_NewLibelle.TabIndex = 0;
            this.l_NewLibelle.Text = "Libellé de la nouvelle classe";
            // 
            // tb_NewLibelle
            // 
            this.tb_NewLibelle.Location = new System.Drawing.Point(157, 34);
            this.tb_NewLibelle.Name = "tb_NewLibelle";
            this.tb_NewLibelle.Size = new System.Drawing.Size(161, 20);
            this.tb_NewLibelle.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(16, 72);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(135, 23);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(183, 72);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(135, 23);
            this.bt_Close.TabIndex = 3;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // FormClasseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 107);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_NewLibelle);
            this.Controls.Add(this.l_NewLibelle);
            this.Name = "FormClasseAdd";
            this.Text = "Ajouter une classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_NewLibelle;
        private System.Windows.Forms.TextBox tb_NewLibelle;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Close;
    }
}