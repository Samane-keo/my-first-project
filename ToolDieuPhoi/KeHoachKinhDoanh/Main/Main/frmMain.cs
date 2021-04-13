using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using System.Reflection;
using Class;
using AccessData;

namespace Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        clsMain main = new clsMain();
        ActivityMonitor.ActivityMonitor _am = new ActivityMonitor.ActivityMonitor();

        public frmMain()
        {
            InitializeComponent();
            BuildMenu();
            
            InitSkins("Office 2010 Blue");
            //ShowForm("frmDieuPhoi", "KeHoachKinhDoanh");
            Load_StatusInfo();

            //ACTIVITY MONITOR
            //_am.WarningMinutes = 0.9;
            //_am.MaxMinutesIdle = 10;
            //_am.Idle += new EventHandler(am_Idle);

            //activityMonitorBindingSource.DataSource = _am;
        }
        void am_Idle(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //INIT SKIN
        private void InitSkins(string skins)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(skins);
        }
        //Load thông tin User lên thanh trạng thái bottom
        private void Load_StatusInfo()
        {
            lblusername.Caption = clsGlobalVariable.username_;
            //lblpermission.Caption = clsGlobalVariable.groupid_;
            lbltime.Caption = DateTime.Now.ToString();
        }
        //
        public void BuildMenu()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            int userid = Convert.ToInt32(clsGlobalVariable.userid_);

            dt = main.Load_LeftMenu(userid);
            navBarControl1.Groups.Clear();
            navBarControl1.BeginUpdate();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NavBarGroup groupLocal = new NavBarGroup(dt.Rows[i]["Description"].ToString());
                    navBarControl1.Groups.Add(groupLocal);
                    dt2 = main.Load_ChildMenu(int.Parse(dt.Rows[i]["ProjectID"].ToString()), userid);
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        NavBarItem items = new NavBarItem(dt2.Rows[j]["TenMenu"].ToString());
                        items.Tag = dt2.Rows[j]["TenForm"].ToString();
                        items.Name = dt2.Rows[j]["ProjectName"].ToString();
                        groupLocal.ItemLinks.Add(items);
                        groupLocal.Expanded = true;
                    }
                }
            }
            navBarControl1.EndUpdate();
        }

        public void ShowForm(string tenmenu, string project)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(frmWaitForm));
            try
            {
                if (tenmenu.Substring(0, 2).ToUpper() == "UC")
                {
                    Type tmp;
                    Assembly assemblyProject = Assembly.LoadFile(string.Format(@"{0}\{1}.dll", Application.StartupPath, project));
                    tmp = assemblyProject.GetType(project + "." + tenmenu, false, true);
                    UserControl uctmp = new UserControl();
                    uctmp = (UserControl)Activator.CreateInstance(tmp);
                    splitContainerControl1.Panel2.Controls.Add(uctmp);
                }
                else
                {
                    Type tmp;
                    Assembly assemblyProject = Assembly.LoadFile(string.Format(@"{0}\{1}.dll", Application.StartupPath, project));
                    tmp = assemblyProject.GetType(project + "." + tenmenu, false, true);
                    //CLEAR PANNEL 2
                    Form frm = (Form)Activator.CreateInstance(tmp);
                    frm.TopLevel = false;
                    //REMOVE BORDER
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    
                    splitContainerControl1.Panel2.Controls.Add(frm);
                    frm.Show();
                }
            }
            catch
            {
                if (tenmenu.Substring(0, 2).ToUpper() == "UC")
                {
                    Type tmp;
                    tmp = Type.GetType(project + "." + tenmenu, false, true);
                    UserControl uctmp = new UserControl();
                    uctmp = (UserControl)Activator.CreateInstance(tmp);
                    splitContainerControl1.Panel2.Controls.Add(uctmp);
                }
                else
                {
                    Type tmp;
                    tmp = Type.GetType(project + "." + tenmenu, false, true);
                    Form frm = (Form)Activator.CreateInstance(tmp);
                    frm.TopLevel = false;
                    //REMOVE BORDER
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    splitContainerControl1.Panel2.Controls.Add(frm);
                    frm.Show();
                }
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        #region "Events"
        private void btndangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();            
            this.Hide();
        }
        //ĐỔI MẬT KHẨU
        private void btndoimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            Admin.frmChangePassword frm = new Admin.frmChangePassword();
            frm.TopLevel = false;
            //REMOVE BORDER
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clsGlobalVariable.minutesRemaining_ <= 0)
            {
                Application.ExitThread();
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion             

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ShowForm(e.Link.Item.Tag.ToString(), e.Link.Item.Name.ToString());
        }
    }
}
