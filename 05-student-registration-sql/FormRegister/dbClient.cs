using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRegister
{
    internal class dbClient
    {
        private readonly string cs = "Data Source=.\\SQLEXPRESS;" +
        "Initial Catalog=students;" +
        "Integrated Security=true;" +
        "TrustServerCertificate=True";

        public void addStudents(Students student)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "INSERT INTO student (nimStudent, emailStudent, nameStudent) " +
                    "VALUES (@nim, @username, @email)";

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@nim", student.nim);
                sqlCommand.Parameters.AddWithValue("@username", student.username);
                sqlCommand.Parameters.AddWithValue("@email", student.email);

                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public DataTable getAllStudents()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Student";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        public void updateStudents(Students student)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "UPDATE student SET " +
                    "nameStudent = @username, " +
                    "emailStudent = @email " +
                    "WHERE nimStudent = @nim";

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@nim", student.nim);
                sqlCommand.Parameters.AddWithValue("@username", student.username);
                sqlCommand.Parameters.AddWithValue("@email", student.email);

                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
        public void deleteStudents(string nim)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                string query = "DELETE FROM student WHERE nimStudent = @nim";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nim", nim);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
