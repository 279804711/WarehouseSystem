using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using STMS.Models.DModels;
using Common;
using System.Reflection;

namespace STMS.STMSApp
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //sting tableName = string.Empty;
            //typeof(UserInfo).getName();
            //Type t = typeof(UserInfo);
            //t.GetName();

            //string propertyName = string.Empty;
            //Type t = typeof(UserInfo);
            //PropertyInfo[] properties = t.GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    propertyName = property.GetColName();
            //}

        }
    }
}
