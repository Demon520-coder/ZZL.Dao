using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZL.DataAccess;

namespace Test
{
    public class CustomerService : BaseDao<Customer, int>, ICustomerService
    {

    }
}
