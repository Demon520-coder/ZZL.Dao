using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZL.DataAccess
{
    public class EntityBase<TKey>
    {

        public TKey Id { get; set; }

        public string Remark { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public TKey CreateId { get; set; }

        public TKey ModifyId { get; set; }

        public int Status { get; set; }
    }
}
