using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DollarXpressDataModel
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {
        }

        public Customer(int CustomerID, string FullName, string Nickname, string Address, string PhoneNumber)
        {
            this.CustomerID = CustomerID;
            this.FullName = FullName;
            this.Nickname = Nickname;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
