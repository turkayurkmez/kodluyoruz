using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    //Product işlemleri senin sorumluluğun:
   public class ProductBusiness
    {
        public int AddProduct(string name, decimal price)
        {
            var connectionString = "Data Source =.; Initial Catalog = Northwind; Integrated Security = True";
            DBHelper dBHelper = new DBHelper(connectionString);
            var commandText = "INSERT into Products(ProductName, UnitPrice) values(@name, @price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);
            int affectedRowCount = dBHelper.Execute(commandText, parameters);




            return affectedRowCount;

            
         
        }
    }
}
