using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DollarXpressDataModel;

namespace DollarXpressViewModel
{

    public class CustomersViewModel : ViewInformation
    {
        public List<Customer> Customers { get; set; }

        public CustomersViewModel()
        {
            Customers = new List<Customer>();
            ValidationErrors = new Hashtable();
            ReturnMessage = new List<string>();
        }
    }
}
