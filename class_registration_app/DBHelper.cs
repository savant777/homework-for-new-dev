using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClassRegistrationApp
{
    internal class DBHelper
    {
        private static string dbFile = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\ClassRegistrationDB.mdf"));
        private static string connString = $@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFile};Integrated Security=True;";

        #region Classes
        public static DataTable GetClassesByMonth(int month)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT * FROM Classes WHERE MonthRegistered = @MonthRegistered";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MonthRegistered", month);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable GetClassById(int classId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM Classes WHERE ClassID = @ClassID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        #endregion

        #region Registrations
        public static void CreateRegistrationTable()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Registrations' AND xtype='U')
                    CREATE TABLE Registrations (
                        RegistrationID INT IDENTITY(1,1) PRIMARY KEY,
                        ClassID INT NOT NULL,
                        RegisteredDate DATETIME DEFAULT GETDATE()
                    )";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool IsClassRegistered(int classId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM Registrations WHERE ClassID = @ClassID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static void RegisterClass(int classId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Registrations (ClassID) VALUES (@ClassID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetRegisteredClasses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT c.ClassID, c.ClassName, c.Description, c.PosterPath, c.MonthRegistered
                                 FROM Classes c
                                 INNER JOIN Registrations r ON c.ClassID = r.ClassID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static void CancelRegistration(int classId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "DELETE FROM Registrations WHERE ClassID = @ClassID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClassID", classId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
