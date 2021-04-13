namespace Admin
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbluserid = new DevExpress.XtraEditors.LabelControl();
            this.cbodepartment = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.chbisactive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.gcuser = new DevExpress.XtraGrid.GridControl();
            this.gvuser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbodepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbisactive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbluserid);
            this.panelControl1.Controls.Add(this.cbodepartment);
            this.panelControl1.Controls.Add(this.txtpassword);
            this.panelControl1.Controls.Add(this.txtfullname);
            this.panelControl1.Controls.Add(this.txtusername);
            this.panelControl1.Controls.Add(this.chbisactive);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 145);
            this.panelControl1.TabIndex = 0;
            // 
            // lbluserid
            // 
            this.lbluserid.Location = new System.Drawing.Point(494, 18);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(0, 13);
            this.lbluserid.TabIndex = 10;
            this.lbluserid.Visible = false;
            // 
            // cbodepartment
            // 
            this.cbodepartment.Location = new System.Drawing.Point(338, 10);
            this.cbodepartment.Name = "cbodepartment";
            this.cbodepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbodepartment.Properties.NullText = "";
            this.cbodepartment.Properties.View = this.gridLookUpEdit1View;
            this.cbodepartment.Size = new System.Drawing.Size(150, 20);
            this.cbodepartment.TabIndex = 9;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(105, 67);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(143, 21);
            this.txtpassword.TabIndex = 8;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(105, 10);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(143, 21);
            this.txtfullname.TabIndex = 6;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(105, 38);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(143, 21);
            this.txtusername.TabIndex = 7;
            // 
            // chbisactive
            // 
            this.chbisactive.Location = new System.Drawing.Point(338, 39);
            this.chbisactive.Name = "chbisactive";
            this.chbisactive.Properties.Caption = "isActive";
            this.chbisactive.Size = new System.Drawing.Size(75, 19);
            this.chbisactive.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tên đăng nhập:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(277, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Phòng ban:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Họ tên:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btncancel);
            this.panelControl2.Controls.Add(this.btnsave);
            this.panelControl2.Controls.Add(this.btndelete);
            this.panelControl2.Controls.Add(this.btnedit);
            this.panelControl2.Controls.Add(this.btnnew);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 102);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(884, 43);
            this.panelControl2.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.Location = new System.Drawing.Point(406, 7);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 30);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Bỏ qua";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(310, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 30);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Lưu dữ liệu";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(214, 7);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 30);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(118, 7);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(90, 30);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(22, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(90, 30);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "Thêm mới";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // gcuser
            // 
            this.gcuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcuser.Location = new System.Drawing.Point(0, 145);
            this.gcuser.MainView = this.gvuser;
            this.gcuser.Name = "gcuser";
            this.gcuser.Size = new System.Drawing.Size(884, 520);
            this.gcuser.TabIndex = 1;
            this.gcuser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvuser});
            // 
            // gvuser
            // 
            this.gvuser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserID,
            this.Username,
            this.Password,
            this.Fullname,
            this.Department,
            this.isActive});
            this.gvuser.GridControl = this.gcuser;
            this.gvuser.Name = "gvuser";
            this.gvuser.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvuser_RowCellClick);
            // 
            // UserID
            // 
            this.UserID.Caption = "UserID";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            // 
            // Username
            // 
            this.Username.Caption = "Tên đăng nhập";
            this.Username.FieldName = "Username";
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            // 
            // Password
            // 
            this.Password.Caption = "Mật khẩu";
            this.Password.FieldName = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = true;
            this.Password.VisibleIndex = 1;
            // 
            // Fullname
            // 
            this.Fullname.Caption = "Họ tên";
            this.Fullname.FieldName = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.Visible = true;
            this.Fullname.VisibleIndex = 2;
            // 
            // Department
            // 
            this.Department.Caption = "Phòng ban";
            this.Department.FieldName = "Department";
            this.Department.Name = "Department";
            this.Department.Visible = true;
            this.Department.VisibleIndex = 3;
            // 
            // isActive
            // 
            this.isActive.Caption = "Đang hoạt động";
            this.isActive.FieldName = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.Visible = true;
            this.isActive.VisibleIndex = 4;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.gcuser);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUser";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbodepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbisactive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit chbisactive;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtusername;
        private DevExpress.XtraEditors.GridLookUpEdit cbodepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraGrid.GridControl gcuser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvuser;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraGrid.Columns.GridColumn Fullname;
        private DevExpress.XtraGrid.Columns.GridColumn Department;
        private DevExpress.XtraGrid.Columns.GridColumn isActive;
        private DevExpress.XtraEditors.LabelControl lbluserid;
    }
}