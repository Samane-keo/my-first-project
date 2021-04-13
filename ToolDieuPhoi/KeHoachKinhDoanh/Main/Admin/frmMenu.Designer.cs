namespace Admin
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblmenuid = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txttenform = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.txttenmenu = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcmenu = new DevExpress.XtraGrid.GridControl();
            this.gvmenu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MenuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenForm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbochuongtrinh = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbochuongtrinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbochuongtrinh);
            this.panelControl1.Controls.Add(this.txtpos);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblmenuid);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txttenform);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.txttenmenu);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 92);
            this.panelControl1.TabIndex = 3;
            // 
            // lblmenuid
            // 
            this.lblmenuid.Location = new System.Drawing.Point(799, 19);
            this.lblmenuid.Name = "lblmenuid";
            this.lblmenuid.Size = new System.Drawing.Size(11, 13);
            this.lblmenuid.TabIndex = 18;
            this.lblmenuid.Text = "ID";
            this.lblmenuid.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Chương trình";
            // 
            // txttenform
            // 
            this.txttenform.Location = new System.Drawing.Point(522, 15);
            this.txttenform.Name = "txttenform";
            this.txttenform.Size = new System.Drawing.Size(143, 21);
            this.txttenform.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(469, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Tên form:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btncancel);
            this.panelControl2.Controls.Add(this.btnsave);
            this.panelControl2.Controls.Add(this.btndelete);
            this.panelControl2.Controls.Add(this.btnedit);
            this.panelControl2.Controls.Add(this.btnnew);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 49);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(884, 43);
            this.panelControl2.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(414, 6);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 30);
            this.btncancel.TabIndex = 34;
            this.btncancel.Text = "Bỏ qua";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(314, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 30);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "Lưu dữ liệu";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(215, 6);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 30);
            this.btndelete.TabIndex = 32;
            this.btndelete.Text = "Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(116, 6);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(90, 30);
            this.btnedit.TabIndex = 31;
            this.btnedit.Text = "Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(18, 6);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(90, 30);
            this.btnnew.TabIndex = 30;
            this.btnnew.Text = "Thêm mới";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txttenmenu
            // 
            this.txttenmenu.Location = new System.Drawing.Point(309, 15);
            this.txttenmenu.Name = "txttenmenu";
            this.txttenmenu.Size = new System.Drawing.Size(143, 21);
            this.txttenmenu.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(252, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Tên menu:";
            // 
            // gcmenu
            // 
            this.gcmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcmenu.Location = new System.Drawing.Point(0, 92);
            this.gcmenu.MainView = this.gvmenu;
            this.gcmenu.Name = "gcmenu";
            this.gcmenu.Size = new System.Drawing.Size(884, 573);
            this.gcmenu.TabIndex = 5;
            this.gcmenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmenu});
            // 
            // gvmenu
            // 
            this.gvmenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MenuID,
            this.TenMenu,
            this.TenForm,
            this.ProjectName,
            this.ProjectID,
            this.STT});
            this.gvmenu.GridControl = this.gcmenu;
            this.gvmenu.Name = "gvmenu";
            this.gvmenu.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvmenu_RowCellClick);
            // 
            // MenuID
            // 
            this.MenuID.Caption = "Menu ID";
            this.MenuID.FieldName = "MenuID";
            this.MenuID.Name = "MenuID";
            this.MenuID.Visible = true;
            this.MenuID.VisibleIndex = 0;
            // 
            // TenMenu
            // 
            this.TenMenu.Caption = "Tên menu";
            this.TenMenu.FieldName = "TenMenu";
            this.TenMenu.Name = "TenMenu";
            this.TenMenu.Visible = true;
            this.TenMenu.VisibleIndex = 1;
            // 
            // TenForm
            // 
            this.TenForm.Caption = "Tên form";
            this.TenForm.FieldName = "TenForm";
            this.TenForm.Name = "TenForm";
            this.TenForm.Visible = true;
            this.TenForm.VisibleIndex = 2;
            // 
            // ProjectName
            // 
            this.ProjectName.Caption = "Chương trình";
            this.ProjectName.FieldName = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Visible = true;
            this.ProjectName.VisibleIndex = 3;
            // 
            // ProjectID
            // 
            this.ProjectID.Caption = "ProjectID";
            this.ProjectID.FieldName = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "Pos";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 4;
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(707, 15);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(54, 21);
            this.txtpos.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(684, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Pos";
            // 
            // cbochuongtrinh
            // 
            this.cbochuongtrinh.Location = new System.Drawing.Point(80, 15);
            this.cbochuongtrinh.Name = "cbochuongtrinh";
            this.cbochuongtrinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbochuongtrinh.Properties.View = this.gridLookUpEdit1View;
            this.cbochuongtrinh.Size = new System.Drawing.Size(155, 20);
            this.cbochuongtrinh.TabIndex = 21;
            this.cbochuongtrinh.EditValueChanged += new System.EventHandler(this.cbochuongtrinh_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.gcmenu);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbochuongtrinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblmenuid;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txttenform;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private System.Windows.Forms.TextBox txttenmenu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcmenu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvmenu;
        private DevExpress.XtraGrid.Columns.GridColumn MenuID;
        private DevExpress.XtraGrid.Columns.GridColumn TenMenu;
        private DevExpress.XtraGrid.Columns.GridColumn TenForm;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private System.Windows.Forms.TextBox txtpos;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit cbochuongtrinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;

    }
}