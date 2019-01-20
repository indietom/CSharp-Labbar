using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    class DatabaseManager
    {
        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Database1.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlCommand command = new SqlCommand();

        public DatabaseManager()
        {
            
        }

        public void Add(string name, string description)
        {
            
        }

        public void Delete(int id)
        {
            
        }

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
