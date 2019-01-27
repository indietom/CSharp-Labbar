using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Data;

namespace Logic
{
    /// <summary>
    /// Manipulate the database
    /// </summary>
    public class DatabaseManager
    {
        /// <summary>
        /// Connection string
        /// </summary>
        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlCommand command = new SqlCommand();

        public DatabaseManager()
        {
            
        }

        /// <summary>
        /// Build the command string, open connectin and runn
        /// </summary>
        /// <param name="id">id to instert</param>
        /// <param name="name">name to insert</param>
        /// <param name="description">description to insert</param>
        public void Add(int id, string name, string description)
        {
            name = "\'" + name + "\'";
            description = "\'" + description + "\'";
            string toExecute = "INSERT INTO Test (ID,Name,Description) VALUES (" + id + "," + name + ", " + description + ");";

            command = new SqlCommand(toExecute, connection);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
        }

        /// <summary>
        /// Delete based on id
        /// </summary>
        /// <param name="id">id to delete</param>
        public void Delete(int id)
        {
            string toExecute = "DELETE FROM Test WHERE id="+id + ";";
            command = new SqlCommand(toExecute, connection);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
        }

        /// <summary>
        /// Get a Test enitiy based on id
        /// </summary>
        /// <param name="id">id to check</param>
        /// <returns>the enitity</returns>
        public Test Get(int id)
        {
            string name = "";
            string descrption = "";
            command = new SqlCommand("SELECT * FROM Test where id=" + id, connection);
            connection.Open();
            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    name = oReader["Name"].ToString();
                    descrption = oReader["Descrption"].ToString();
                }
            }
            connection.Close();

            return new Test { Name = name, Description = descrption};
        }
    }
}
