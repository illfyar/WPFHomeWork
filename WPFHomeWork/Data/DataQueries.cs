using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFHomeWork.Data
{
    static class DataQueries
    {
        const string CONNECTIONSTRING = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=ZUP;" +
            "Integrated Security=True;" +
            "Pooling = true;";

        public static DataTable SelectEmployes()
        {
            StringBuilder sqlText = new StringBuilder(
                "Select Employee.Id," +
                "Person.LastName," +
                "Person.FirstName," +
                "Person.DateBorn," +
                "Position.PositionName," +
                "Department.DepartmentName," +
                "Salary.Value," +
                "Person.Id AS Person_Id," +
                "Position.Id AS Position_Id," +
                "Department.Id AS Department_Id," +
                "Salary.Id AS Salary_Id " +
                "From Employee " +
                "Left join Person on Person_id = Person.Id " +
                "Left join Position on Employee.Position_id = Position.Id " +
                "Left join Department on Department_id = Department.Id " +
                "Left Join Salary on Salary_id = Salary.Id");           

                return ExecuteSelect(sqlText.ToString());
        }

        public static DataTable SelectPositions()
        {
            StringBuilder sqlText = new StringBuilder(
                "Select Position.Id," +
                "Position.PositionName " +
                "From Position");

            return ExecuteSelect(sqlText.ToString());            
        }
        public static DataTable ObservableCollectionDepartments()
        {
            StringBuilder sqlText = new StringBuilder(
                "Select Department.Id," +
                "Department.DepartmentName," +
                "Department.Parent " +
                "From Department");

            return ExecuteSelect(sqlText.ToString());
        }

        private static DataTable ExecuteSelect(string sqlText)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(CONNECTIONSTRING))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlText.ToString(), sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                DataColumn[] pk = new DataColumn[1];
                pk[0] = dataTable.Columns["Id"];
                dataTable.PrimaryKey = pk;

                return dataTable;
            }
        }
    }
}
