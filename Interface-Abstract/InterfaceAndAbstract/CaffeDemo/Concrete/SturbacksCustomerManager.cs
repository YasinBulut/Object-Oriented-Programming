using CaffeDemo.Abstract;
using CaffeDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeDemo.Concrete
{
    public class SturbacksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public SturbacksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
          
        }

    }
}
