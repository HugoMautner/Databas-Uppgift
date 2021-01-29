using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.Collections.Generic;

namespace DatabasUppgift
{
    class SqliteDataAccess
    {
        public void SaveStudent(StudentModel student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO student (first_name, last_name, adress, phone_number, e_mail)" +
                    "VALUES (@first_name, @last_name, @adress, @phone_number, @e_mail)", student);
            }
        }

        public static List<StudentModel> LoadStudents()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<StudentModel>(
                    "SELECT * FROM student", new DynamicParameters());

                return result.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
