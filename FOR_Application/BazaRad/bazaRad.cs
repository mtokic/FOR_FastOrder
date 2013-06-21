using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DBHelper
{
    /// <summary>
    /// Kreiramo klasu za rad s bazom podataka
    /// </summary>
    
    public class bazaRad
    {
        private SqlConnection connection;
        private string ConnectionString = "Data Source=161.53.120.217\\VARAZDIN,1433;Initial Catalog=pi2013FastOrderdb;User ID=pi2013FastOrder;Password=pi2013FastOrder";


        /// <summary>
        /// Kreiramo konstruktor
        /// </summary>
        public bazaRad()
        {
        }

        /// <summary>
        /// Metoda kojom cemo otvarati nove konekcije prema bazi
        /// </summary>
        public bool OpenConnection()
        {
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException )
            {
                return false;
            }
        }

        /// <summary>
        /// Metoda za izvršavanje SQL upita nad bazom
        /// </summary>
        /// <param name="query">Sadržaj upita</param>
        protected bool Query(string query)
        {
            bool val = false;
            if (OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    val = true;
                }
                catch (SqlException )
                {
                    
                    val = false;
                }
            }
            return val;

        }

        /// <summary>
        /// Metoda za izvršavanje SQL upita nad bazom
        /// </summary>
        /// <param name="query">Upit</param>
        /// <returns></returns>
        public SqlDataReader QueryReader(string query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Metoda kojom zatvaramo otvorenu konekciju
        /// </summary>
        protected bool CloseConnection()
        {
            bool val = false;
            if (connection != null)
            {
                val = true;
                connection.Close();
                connection.Dispose();
            }
            return val;
        }


    }
}
