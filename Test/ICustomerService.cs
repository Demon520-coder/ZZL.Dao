using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZL.DataAccess;

namespace Test
{
    public interface ICustomerService : IBaseDao<Customer, int>
    {

    }
}
