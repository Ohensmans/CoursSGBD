namespace NorthWind
{
    partial class FormTerritoires
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bt_SaveAll = new System.Windows.Forms.Button();
            this.bt_LoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(764, 377);
            this.dataGrid.TabIndex = 0;
            // 
            // bt_SaveAll
            // 
            this.bt_SaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SaveAll.Location = new System.Drawing.Point(537, 413);
            this.bt_SaveAll.Name = "bt_SaveAll";
            this.bt_SaveAll.Size = new System.Drawing.Size(239, 44);
            this.bt_SaveAll.TabIndex = 1;
            this.bt_SaveAll.Text = "Save All";
            this.bt_SaveAll.UseVisualStyleBackColor = true;
            this.bt_SaveAll.Click += new System.EventHandler(this.bt_SaveAll_Click);
            // 
            // bt_LoadAll
            // 
            this.bt_LoadAll.Location = new System.Drawing.Point(12, 413);
            this.bt_LoadAll.Name = "bt_LoadAll";
            this.bt_LoadAll.Size = new System.Drawing.Size(239, 44);
            this.bt_LoadAll.TabIndex = 2;
            this.bt_LoadAll.Text = "Load All";
            this.bt_LoadAll.UseVisualStyleBackColor = true;
            this.bt_LoadAll.Click += new System.EventHandler(this.bt_LoadAll_Click);
            // 
            // FormTerritoires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 469);
            this.Controls.Add(this.bt_LoadAll);
            this.Controls.Add(this.bt_SaveAll);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormTerritoires";
            this.Text = "Territoires";
            this.Load += new System.EventHandler(this.FormTerritoires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button bt_SaveAll;
        private System.Windows.Forms.Button bt_LoadAll;
    }
}