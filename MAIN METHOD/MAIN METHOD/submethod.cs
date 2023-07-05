using System;
using System.Collections.Generic;
using System.Text;

namespace MAIN_METHOD
{
    public class submethod
    {
        public static int Math(int intnum)
        {
            int result1 = intnum * 2;
            return result1;

        }

        public static int Math(decimal decnum)
        {            
            int result2 = (int)(decnum + 1);
            return result2;

        }
        
        public static int Math(string stringnumber)
        {            
            int result3 = Convert.ToInt32(stringnumber) + 1;
            return result3;

        }
    }
}
