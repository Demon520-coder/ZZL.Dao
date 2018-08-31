using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZL.Common
{
    public class ScopeAttribute : Attribute
    {
        public string Name { get; set; }

        public string Key { get; set; }
    }
}
