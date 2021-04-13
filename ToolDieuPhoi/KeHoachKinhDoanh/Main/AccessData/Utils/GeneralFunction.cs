using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace AccessData.Utils
{
    public static class GeneralFunction
    {
        const string EMPTYSTRING = "";
        public static string MyTrim(this string str)
        {
            if (str == null)
                return EMPTYSTRING;
            return str.Replace("'", "\'").Trim();
        }
        public static string MyTrim(this object str)
        {
            try
            {
                if (str != null)
                {
                    return str.ToString().Trim();
                }
                return EMPTYSTRING;
            }

            catch
            {
                return EMPTYSTRING;
            }
        }
        public static int MyToInt(this object pString)
        {
            if (pString.MyTrim() == "")
                return -1;
            try
            {
                int result = 0;
                int.TryParse(pString.MyTrim(), out result);
                return result;

            }
            catch
            {
                return -1;
            }
        }
        //public static int MyBool(this object pString)
        //{
        //    if (pString.MyTrim() == "")
        //        return -1;
        //}
        public static bool ValidateMandantoryField(Control pControl)
        {
            var origColor = pControl.BackColor;
            if (pControl.Text.MyTrim() == EMPTYSTRING)
            {
                pControl.Focus();
                pControl.BackColor = System.Drawing.Color.Red;
                Application.DoEvents();
                //ShowError(PP2IT_Const.MESSAGECODE.INPUT_REQUIRED);
                MessageBox.Show("Vui lòng nhập giá trị vào trường dữ liệu bắt buộc tại " + pControl.Name);
                //  ShowInformation("Vui lòng nhập giá trị vào trường dữ liệu bắt buộc tại " + pControl.Name);
                pControl.BackColor = origColor;
                return false;
            }
            return true;
        }


    }
}
