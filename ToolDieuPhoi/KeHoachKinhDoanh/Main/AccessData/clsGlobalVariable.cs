using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public class clsGlobalVariable
    {
        //ADMIN
        public static string userid_;
        public static string username_;
        public static string password_;
        public static string fullname_;
        public static string department_;

        public static double minutesRemaining_;
        //QUẢN LÝ NHÂN SỰ
        public static string manv_;
        public static DateTime date_;
        //HÀM VIẾT HOA CHỮ CÁI ĐẦU TIÊN TRONG CHUỖI
        public static string ToFirstUpper(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            string result = "";
            //lấy danh sách các từ  
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }
            }
            return result.Trim();
        }
    }
}
