namespace Admin
{
    partial class frmProject
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
            this.gcproject = new DevExpress.XtraGrid.GridControl();
            this.gvproject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcproject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproject)).BeginInit();
            this.SuspendLayout();
            // 
            // gcproject
            // 
            this.gcproject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcproject.Location = new System.Drawing.Point(0, 0);
            this.gcproject.MainView = this.gvproject;
            this.gcproject.Name = "gcproject";
            this.gcproject.Size = new System.Drawing.Size(884, 665);
            this.gcproject.TabIndex = 0;
            this.gcproject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvproject});
            // 
            // gvproject
            // 
            this.gvproject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProjectID,
            this.ProjectName,
            this.Description});
            this.gvproject.GridControl = this.gcproject;
            this.gvproject.Name = "gvproject";
            this.gvproject.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvproject.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvproject.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvproject.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvproject_ValidateRow);
            // 
            // ProjectID
            // 
            this.ProjectID.Caption = "Mã chương trình";
            this.ProjectID.FieldName = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.OptionsColumn.ReadOnly = true;
            this.ProjectID.Visible = true;
            this.ProjectID.VisibleIndex = 0;
            // 
            // ProjectName
            // 
            this.ProjectName.Caption = "Tên chương trình";
            this.ProjectName.FieldName = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Visible = true;
            this.ProjectName.VisibleIndex = 1;
            // 
            // Description
            // 
            this.Description.Caption = "Diễn giải";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.gcproject);
            this.Name = "frmProject";
            this.Text = "frmProject";
            this.Load += new System.EventHandler(this.frmProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcproject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvproject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcproject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvproject;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}