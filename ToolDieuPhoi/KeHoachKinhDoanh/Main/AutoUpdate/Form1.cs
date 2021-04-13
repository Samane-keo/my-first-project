using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Upt();
        }
        public void Upt()
        {
            string pathserver = "";
            string verexe_cli = "", verrpt_cli = "";
            string verexe_ser = "", verrpt_ser = "";
            //
            string qlns_cli = "", chamcong_cli = "";
            string qlns_ser = "", chamcong_ser = "";
            string quannlysanxuat_cli = "", quannlysanxuat_ser = "";
            string kehoachkinhdoanh_cli = "", kehoachkinhdoanh_ser = "";

            var client = new IniFile(Application.StartupPath + "\\Extention\\Main.ini");
            verexe_cli = client.Read("EXE", "Update");
            verrpt_cli = client.Read("REPORT", "Update");
            qlns_cli = client.Read("QLNS", "Update");
            chamcong_cli = client.Read("CHAMCONG", "Update");
            quannlysanxuat_cli = client.Read("QLSX", "Update");
            kehoachkinhdoanh_cli = client.Read("KHKD", "Update");

            pathserver = client.Read("Path", "Source");

            var server = new IniFile(pathserver + "\\Extention\\Main.ini");
            verexe_ser = server.Read("EXE", "Update");
            verrpt_ser = server.Read("REPORT", "Update");
            qlns_ser = server.Read("QLNS", "Update");
            chamcong_ser = server.Read("CHAMCONG", "Update");
            quannlysanxuat_ser = server.Read("QLSX", "Update");
            kehoachkinhdoanh_ser = client.Read("KHKD", "Update");
            //if (verexe_cli != verexe_ser)
            //{
            //    File.Copy(pathserver + "\\Main.exe", Application.StartupPath + "\\Main.exe", true);
            //    client.Write("EXE", verexe_ser, "Update");
            //}
            if (verrpt_cli != verrpt_ser)
            {
                DirectoryCopy(pathserver + "\\Reports", Application.StartupPath + "\\Reports", true);
                client.Write("REPORT", verrpt_ser, "Update");
            }
            //UPDATE QUẢN LÝ NHÂN SỰ
            if (qlns_cli != qlns_ser)
            {
                File.Copy(pathserver + "\\HumanResource.dll", Application.StartupPath + "\\HumanResource.dll", true);
                client.Write("QLNS", qlns_ser, "Update");
            }
            //UPDATE CHẤM CÔNG
            if (chamcong_cli != chamcong_ser)
            {
                File.Copy(pathserver + "\\AttendanceManagement.dll", Application.StartupPath + "\\AttendanceManagement.dll", true);
                client.Write("CHAMCONG", chamcong_ser, "Update");
            }
            //UPDATE QUẢN LÝ SẢN XUẤT
            if (quannlysanxuat_cli != quannlysanxuat_ser)
            {
                File.Copy(pathserver + "\\ProductionPlan.dll", Application.StartupPath + "\\ProductionPlan.dll", true);
                client.Write("QLSX", quannlysanxuat_ser, "Update");
            }
            //UPDATE KỂ HOẠCH KINH DOANH
            if (kehoachkinhdoanh_cli != kehoachkinhdoanh_ser)
            {
                File.Copy(pathserver + "\\KeHoachKinhDoanh.dll", Application.StartupPath + "\\KeHoachKinhDoanh.dll", true);
                client.Write("KHKD", kehoachkinhdoanh_ser, "Update");
            }
            //UPDATE FILE EXE
            if (verexe_cli != verexe_ser)
            {
                File.Copy(pathserver + "\\Main.exe", Application.StartupPath + "\\Main.exe", true);
                client.Write("EXE", verexe_ser, "Update");
            }

            System.Diagnostics.Process.Start("Main.exe");
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            //// If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Dispose();
        }
    }
}
