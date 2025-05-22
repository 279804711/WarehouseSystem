using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS.Models.DModels
{
    /// <summary>
    /// 仓库信息实体
    /// </summary>
    public class StoreInfo
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreNo { get; set; }
        public int RegionCount { get; set; }
        public string Remark { get; set; }
        public int IsDeleted { get; set; }

    }
}
