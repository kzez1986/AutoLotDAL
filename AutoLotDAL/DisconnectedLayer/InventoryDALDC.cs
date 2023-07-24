using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace AutoLotDAL.DisconnectedLayer
{
    public class InventoryDALDC
    {
        private string _connectionString;
        private SqlDataAdapter _adapter = null;

        public InventoryDALDC(string connectionString)
        {
            _connectionString = connectionString;

            ConfigureAdapter(out _adapter);
        }

        public void ConfigureAdapter(out SqlDataAdapter adapter)
        {
            adapter = new SqlDataAdapter("Select * From Inventory", _connectionString);

            var builder = new SqlCommandBuilder(adapter);
        }
    }
}
