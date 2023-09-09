namespace FilesMaintenaceAPP
{
    partial class GrdData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrdData));
            this.dgvVistaData = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVistaData
            // 
            this.dgvVistaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVistaData.Location = new System.Drawing.Point(0, 0);
            this.dgvVistaData.Name = "dgvVistaData";
            this.dgvVistaData.Size = new System.Drawing.Size(800, 150);
            this.dgvVistaData.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(701, 156);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 64);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GrdData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvVistaData);
            this.Name = "GrdData";
            this.Text = "GrdData";
            this.Load += new System.EventHandler(this.GrdData_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVistaData;
        private System.Windows.Forms.Button btnStart;
    }
}