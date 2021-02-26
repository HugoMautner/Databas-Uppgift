﻿using System;
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
                cnn.Execute("INSERT INTO student (first_name, last_name, adress, phone_number, e_mail) " +
                    "VALUES (@first_name, @last_name, @adress, @phone_number, @e_mail)", student);
            }
        }


        public void RemoveStudent(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM student " +
                    "WHERE id = '" + id + "'");
            }
        }

        public void RemoveGuardian(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM guardian " +
                    "WHERE id = '" + id + "'");
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
        public static List<GuardianModel> LoadGuardians()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<GuardianModel>(
                    "SELECT * FROM guardian", new DynamicParameters());

                return result.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
