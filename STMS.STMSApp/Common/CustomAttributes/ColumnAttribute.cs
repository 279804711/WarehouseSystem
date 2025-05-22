using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    /// <summary>
    /// 列名映射特性
    /// </summary>
    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; protected set; }

        public ColumnAttribute(string colName)
        {
            this.ColumnName = colName;
        }

    }
}
