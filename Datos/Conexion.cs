using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dato
    {
       
    }
    public class Adapter
    {

        private SqlConnection _sqlConn;
        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }
        protected void OpenConnection()
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=FEDE-PC\\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True");
            sqlConn.Open();
        }
        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }
        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }

}
