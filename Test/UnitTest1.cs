using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZZL.Common;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        CustomerService service = new CustomerService();

        [TestMethod]
        public void TryToInt()
        {
            string str = "ad";
            var result = str.TryToInt();
            Assert.IsTrue(result != 0);
        }

        [TestMethod]

        public void IsNullOrEmpty()
        {
            string str = " ";
            var result = str.IsNullOrEmpty();

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetList()
        {
            var list = service.GetList(null);

            Assert.IsTrue(list?.Count() > 0);
        }

        [TestMethod]
        public void GetRecord()
        {
            var record = service.GetRecord(null);

            Assert.IsTrue(record >= 0);
        }

        [TestMethod]
        public void Find()
        {
            Assert.IsNotNull(service.Find(10));
        }

        [TestMethod]
        public void Save()
        {
            var id = service.Save(new Customer
            {
                companyname = "zzl",
                country = "China",
                phone = "13699210799"
            }, "Save");

            Assert.IsTrue(id);
        }

        [TestMethod]
        public void Update()
        {
            Customer customer = service.Find(1);
            customer.companyname = "zzl_01";
            Assert.IsTrue(service.Update(customer), "更新失败");
        }

        [TestMethod]
        public void GetCustomers()
        {
            var list = service.GetList<TestModel>(null, "GetCustomers");

            Assert.IsTrue(list.Count() > 0);
        }
    }
}
