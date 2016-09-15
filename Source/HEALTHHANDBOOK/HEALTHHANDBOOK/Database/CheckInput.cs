using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEALTHHANDBOOK.Database
{
    class CheckInput
    {
            //-----------------------------------------
            //Desc: Mã hóa chuỗi dùng giải thuật md5
            //-----------------------------------------
            public static byte[] encryptData(string data)
            {
                System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hashedBytes;
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
                return hashedBytes;
            }

            //-----------------------------------------
            //Desc: Mã hóa chuỗi
            //-----------------------------------------
            public static string MaHoa(string data)
            {
                return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
            }

            //-----------------------------------------
            //Desc: Kiểm tra keycode
            //-----------------------------------------
            public static bool CheckKeyCode(int keycode)
            {
                if ((keycode >= 48 && keycode <= 57) || keycode == 45 || keycode == 46 || keycode == 8)
                    return true;
                return false;
            }

            //-----------------------------------------
            //Desc: Kiểm tra ký tự đặc biệt
            //-----------------------------------------
            public static bool IsSpecialKey(int keycode)
            {
                if ((keycode >= 33 && keycode <= 47) || (keycode >= 58 && keycode <= 64)
                    || (keycode >= 91 && keycode <= 96) || (keycode >= 123 && keycode <= 126))
                    return true;
                return false;
            }

            //-----------------------------------------
            //Desc: xóa khoảng trằng thừa
            //-----------------------------------------
            public static string ClearSpace(string input)
            {
                int i = 0;
                string output = input;
                while (i < output.Length - 1)
                {
                    if (output[i] == ' ' && output[i + 1] == ' ')
                        output = output.Remove(i, 1);
                    else
                        i++;
                }
                return output.Trim();
            }

            //-----------------------------------------
            //Desc: hàm cắt chuỗi
            //-----------------------------------------
            public static List<string> SplitString(string str)
            {
                List<string> list = new List<string>();
                int i = 0;
                int j = 0;
                try
                {
                    while (i < str.Length)
                    {
                        while (i < str.Length && str[i] == ' ')
                            i++;
                        j = i;
                        while (j < str.Length && str[j] != ' ')
                            j++;
                        if (j != i)
                        {
                            string s = str.Substring(i, j - i).ToLower();
                            if (!list.Contains(s))
                                list.Add(s);
                            i = j;
                        }
                    }
                }
                catch { }

                return list;
            }
        }
}
