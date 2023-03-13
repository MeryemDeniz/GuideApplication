using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeesDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        public int returnvalues;

        public EmployeesDAL()
        {
            con = new SqlConnection("data source = DESKTOP-3GG750G; initial catalog = GuideApp; Integrated Security=true;");
        }

        public void connectSet()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }

        public SqlDataReader List()
        {
            cmd = new SqlCommand("Select * from Employees", con);
            connectSet();
            return cmd.ExecuteReader();
        }


    }


}
