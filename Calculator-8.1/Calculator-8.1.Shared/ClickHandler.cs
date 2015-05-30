using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_8._1
{
    class ClickHandler
    {
        public static bool isDot(string num)
        {
            string[] splitStr = num.Split('.');
            if (splitStr.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
