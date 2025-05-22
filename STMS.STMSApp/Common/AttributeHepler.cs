using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.CustomAttributes;

namespace Common
{
    public static class AttributeHepler
    {
        /// <summary>
        /// 获取映射表名
        /// </summary>
        /// <returns></returns>
        public static string GetName(this Type type)
        {
            string tableName = string.Empty;
            object[] attrs = type.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (attr is TableAttribute)
                {
                    TableAttribute tableAttribute = attr as TableAttribute;
                    tableName = tableAttribute.TableName;
                }
            }
            if (string.IsNullOrEmpty(tableName))
            {
                tableName = string.Empty;
            }
            return tableName;
        }



    }
}
