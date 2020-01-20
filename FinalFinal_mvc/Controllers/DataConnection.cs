using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalFinal_mvc.Models;


namespace FinalFinal_mvc.Controllers
{
    public class DataConnection
    {
        private static string dataConnectionID = "Data Source = DESKTOP-LH42MQ0; Initial Catalog= CustomerDb; Integrated Security = true";

        public static string DataConnectionID
        {
            get { return dataConnectionID; }
            set { dataConnectionID = value; }
        }
    }
}
