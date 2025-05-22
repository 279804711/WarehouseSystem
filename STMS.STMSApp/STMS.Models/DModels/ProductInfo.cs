using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models.DModels
{
    /// <summary>
    /// 产品信息实体
    /// </summary>
    public class ProductInfo
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductNo { get; set; }

        public decimal FitLowTemperature { get; set; }
        public decimal FitHighTemperature { get; set; }

        public int IsDeleted { get; set; }



    }
}
