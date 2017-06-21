using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ForumSystemProject.myModel
{
    public class Model : IModel
    {
        IController _controller;

        public Model(IController controller)
        {
            _controller = controller;
        }
        public bool executeNonQuery(string _command)
        {
            string connectionString = ForumSystemProject.Properties.Settings.Default.DBConnectionString;
            OleDbConnection connection = new OleDbConnection(connectionString);
            int numOfAffected = 0;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(_command);
                command.Connection = connection;
                numOfAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            if (numOfAffected != 0)
                return true;
            else
                return false;
        }

        public DataTable executeQuery(string query)
        {
            string connectionString = ForumSystemProject.Properties.Settings.Default.DBConnectionString;
            OleDbConnection connection = new OleDbConnection(connectionString);
            DataTable dt = null;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter tableAdapter = new OleDbDataAdapter(command);
                dt = new DataTable();
                tableAdapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
