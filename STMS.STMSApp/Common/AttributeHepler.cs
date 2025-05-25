using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
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
                tableName = type.Name;
            }
            return tableName;
        }
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetColName(this PropertyInfo property)
        {
            string colName = string.Empty;
            Object[] attrs = property.GetCustomAttributes(false);
            foreach (var attr in attrs)
            {
                if (attr is ColumnAttribute)
                {
                    ColumnAttribute colAttr = attr as ColumnAttribute;
                    colName = colAttr.ColumnName;
                }

            }
            if (!string.IsNullOrEmpty(colName))
            {
                colName = property.Name;
            }
            return colName;
        }
        /// <summary>
        /// 获取主键名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetPrimary(this Type type)
        {
            string primarykeyName = string.Empty;
            Object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if (attr is PrimaryKeyAttribute)
                { 
                    PrimaryKeyAttribute primaryKeyAttr = attr as PrimaryKeyAttribute;
                    primarykeyName = primaryKeyAttr.PrimaryKey;
                    return primarykeyName;
                }
            }
            return null;
        }
        /// <summary>
        /// 获取是否为主键
        /// </summary>
        /// <param name="type"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsPrimary(this Type type, PropertyInfo property)
        {
            //获取主键名
            string primaryKeyName = type.GetPrimary();
            //获取指定属性的映射列名
            string columnName = property.GetColName();
            //判断是否相等
            return (primaryKeyName == columnName);
        }
        /// <summary>
        /// 判断主键是否自增
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsIncrement(this Type type)
        {
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if(attr is PrimaryKeyAttribute )
                {
                    PrimaryKeyAttribute primaryKeyAttribute = attr as PrimaryKeyAttribute;
                    return primaryKeyAttribute.autoIncrement;
                }
            }
            return false;
        }



    }
}
