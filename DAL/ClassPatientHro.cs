using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ClassPatientHro
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetPatientByHistoryNumberHro(string history_number)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection2();
            command.CommandText = "ObtainPacientDataByHistoryNumber";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@historyNumber", history_number);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection2();
            return tableData;
        }

    }
}
