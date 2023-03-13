using DAL;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace BLL;
public class Business
{
    EmployeesDAL dB = new EmployeesDAL();

    public List<Employees> List()
    {
        List<Employees> employeeList = new List<Employees>();
        try
        {
            SqlDataReader reader = dB.List();
            while (reader.Read())
            {
                employeeList.Add(new Employees()
                {
                    EmployeeID = reader.GetInt32(0),
                    DepartmentID = reader.GetInt32(1),
                    EmployeeName = reader.GetString(2),
                    EmployeeSurname = reader.GetString(3),
                    Address = reader.GetString(4),
                    Email = reader.GetString(5),
                    DepartmentName = reader.GetString(6),

                });
            }
            reader.Close();
        }
        catch (Exception)
        {

        }
        finally
        {
            dB.connectSet();
        }
        return employeeList;
    }

}
