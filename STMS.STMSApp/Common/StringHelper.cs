using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class StringHelper
    {
        /// <summary>
        /// String字符串截取，并转小写
        /// </summary>
        /// <param name="col"></param>
        /// <param name="splitSymbol"></param>
        /// <param name="convertLower"></param>
        /// <returns></returns>
        public static List<string> GetStrList(this string col, char splitSymbol, bool convertLower)
        {
            List<string> cols = new List<string>();
            string[] sArray = col.Split(splitSymbol);
            if(convertLower)//true转换为小写
            {
                for (int i = 0; i < sArray.Length; i++)
                {
                    sArray[i] = sArray[i].ToLower();
                    cols.Add(sArray[i]);
                }
            }
            else
            {
                for (int i = 0; i < sArray.Length; i++)
                {
                    //sArray[i] = sArray[i].ToLower();
                    cols.Add(sArray[i]);
                }
            }
            return cols;
        }


    }
}
