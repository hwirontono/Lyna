using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DollarXpressDataAccessServices;
using DollarXpressViewModel;

namespace DollarXpressBusinessServices
{
    public class CustomerBusinessService
    {

        public CustomersViewModel GetCustomers(string FieldName, string KeyWord)
        {
            CustomersViewModel cvm = new CustomersViewModel();
            CustomerDataAccessService cdas = new CustomerDataAccessService();

            cvm.Customers = cdas.GetCustomers(FieldName, KeyWord);

            return cvm;
        }

    }
}
