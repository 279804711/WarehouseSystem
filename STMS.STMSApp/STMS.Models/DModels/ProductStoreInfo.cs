using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models.DModels
{
    /// <summary>
    /// 产品库存信息实体
    /// </summary>
    public class ProductStoreInfo
    {
        public int ProStoreId { get; set; }

        public int ProductId { get; set; }
        public int StoreId { get; set; }

        public int SRegionId { get; set; }
        public int ProductCount { get; set; }

        public int IsDeleted { get; set; }

    }
}
