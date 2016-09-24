using System;
using System.Collections.Generic;
using System.Text;

namespace POS
{
    class Encryption
    {
        /// <summary>
        /// =============================================ENCEYPTION
        /// </summary>  
        public static string encrypt(string str, byte bt)
        {
            string encrypt = "";

            //USING COALESCING OPERATOR CONDITION
            bt = (bt > 0 && bt <= 13) ? bt : Convert.ToByte(13);

            char[] chr = str.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                //CONVERTING CHAR TO INT
                int x = int.Parse(chr[i].ToString());
                //CONVERTING INT TO CHAR
                encrypt = encrypt + Convert.ToChar((255 - (x + bt - i)));
            }
            return encrypt;
        }

        public static string decrypt(string str, byte bt)
        {
            string encrypt = "";

            //USING COALESCING OPERATOR CONDITION
            bt = (bt > 0 && bt <= 13) ? bt : Convert.ToByte(13);

            char[] chr = str.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                int x = int.Parse(chr[i].ToString());
                encrypt = encrypt + Convert.ToChar(255 + (-x - bt + i));
            }
            return encrypt;
        }
    }
}
