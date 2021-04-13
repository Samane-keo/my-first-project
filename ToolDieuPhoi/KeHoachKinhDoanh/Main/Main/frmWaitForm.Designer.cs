namespace Main
{
    partial class frmWaitForm
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
            this.progwait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // progwait
            // 
            this.progwait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progwait.Appearance.Options.UseBackColor = true;
            this.progwait.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progwait.AppearanceCaption.Options.UseFont = true;
            this.progwait.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progwait.AppearanceDescription.Options.UseFont = true;
            this.progwait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progwait.Location = new System.Drawing.Point(0, 0);
            this.progwait.Name = "progwait";
            this.progwait.Size = new System.Drawing.Size(277, 74);
            this.progwait.TabIndex = 1;
            this.progwait.Text = "progressPanel1";
            // 
            // frmWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 74);
            this.Controls.Add(this.progwait);
            this.Name = "frmWaitForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraWaitForm.ProgressPanel progwait;

    }
}
