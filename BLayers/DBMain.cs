using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm.BLayers
{
    public class DBMain
    {
        string connectionString;
        //string connectionString = "Data Source= localhost;" + "Initial Catalog=Cinema;" + "Integrated Security=SSPI";
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataAdapter dAdapt = null;
        public DBMain(int i)
        {
            if(i == 0)
                connectionString = "Data Source= localhost;Initial Catalog=Cinema;Integrated Security=False;User ID=login123;Password=login";
            else
                connectionString = "Data Source= localhost;Initial Catalog=Cinema;Integrated Security=False;User ID=admin123;Password=admin";
            connection = new SqlConnection(connectionString);
            command = connection.CreateCommand();
        }
        public DataSet TableQuerry(string SQL)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();
            command.CommandText = SQL;
            command.CommandType= CommandType.Text;
            dAdapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            dAdapt.Fill(ds);
            return ds;
        }
        public bool ExecuteNoTable(string SQL)
        {
            bool b= false;
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.Open();
            command.CommandText = SQL;
            command.CommandType = CommandType.Text;
            try
            {
                command.ExecuteNonQuery();
                b = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return b;
        }
    }
}
