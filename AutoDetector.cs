using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class AutoDetector
    {

        private string[] _detectEncodings = { "utf-8", "shift_jis", "EUC-JP","UTF-16","GBK" };

        public string[] DetectEncodings
        {
            get
            {
                return this._detectEncodings;
            }
        }

        public AutoDetector()
        {

        }

        public AutoDetector(string[] detectEncodings)
        {
            this._detectEncodings = detectEncodings;
        }

        public string DetectEncoding(byte[] bytes , ref Encoding encoder)
        {

            foreach(string encode in _detectEncodings)
            {

                encoder = Encoding.GetEncoding(encode);
                if (IsEncode(encoder, bytes))
                {
                    if (encode.ToUpper().Equals("UTF-8"))
                    {
                        if ((bytes[0] == 0xef) && (bytes[1] == 0xbb) && (bytes[2] == 0xbf))
                        {
                            //UTF-8
                            encoder = new System.Text.UTF8Encoding(true);
                            return "UTF-8 with BOM";
                        }
                        else
                        {
                            encoder = new System.Text.UTF8Encoding(false);
                            return "UTF-8";
                        }
                    }
                    return encode;
                }
  

            }
            encoder = null;
            return "unknow";
        }

        private bool IsEncode(Encoding encoder, byte[] buffer)
        {
          
            string decodeText = encoder.GetString(buffer);
            int count=encoder.GetByteCount(decodeText);
            if (count != buffer.Length)
            {
                return false;
            }
            byte[] decodeBytes = encoder.GetBytes(decodeText);
            for (int i =0;i<buffer.Length;i++)
            {
                if (buffer[i] != decodeBytes[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
