using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Main
{
    public partial class frmWaitForm : SplashScreen
    {
        public frmWaitForm()
        {
            InitializeComponent();
            this.Cursor = Cursors.Default;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
            SomeCommandId
        }
    }
}