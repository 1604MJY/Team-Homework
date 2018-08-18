using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class textRestrict
    {
        static public bool restrict(int length, int dot,char keychar)
        {
            if (!Char.IsNumber(keychar) && !Char.IsPunctuation(keychar) && !Char.IsControl(keychar))
            {
                return true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(keychar))
            {
                if (keychar != '.' || length == 0)//小数点  
                {
                    return true;
                }
                if (dot != -1)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
