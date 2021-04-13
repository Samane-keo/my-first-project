namespace KeHoachKinhDoanh
{
    partial class frmImportDieuPhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportDieuPhoi));
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_import = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(346, -1);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(324, 35);
            this.labelControl17.TabIndex = 44;
            this.labelControl17.Text = "THÊM DỮ LIỆU ĐIỀU PHỐI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 427);
            this.dataGridView1.TabIndex = 48;
            // 
            // btn_import
            // 
            this.btn_import.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_import.ImageOptions.Image")));
            this.btn_import.Location = new System.Drawing.Point(12, 57);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(105, 30);
            this.btn_import.TabIndex = 49;
            this.btn_import.Text = "Imports Excel";
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(123, 57);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 30);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "Insert Data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmImportDieuPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 532);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl17);
            this.Name = "frmImportDieuPhoi";
            this.Text = "frmImportDieuPhoi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_import;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}