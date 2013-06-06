using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;


namespace DollarXpressDataAccessServices
{
    public static class Database
    {
        private const string CONNECTION_STRING = "server=DollarXpress2.db.8854937.hostedresource.com;user=DollarXpress2;database=DollarXpress2;port=3306;password=Abcd#1234;";

        public static string DollarExpressDB()
        {
            return CONNECTION_STRING;
        }
    }
}
