using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.Collections.Generic;

namespace DatabasUppgift
{
    static class SqliteDataAccess
    {
        public static void SaveStudent(StudentModel student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO students (first_name, last_name, adress, phone_number, e_mail) " +
                    "VALUES (@first_name, @last_name, @adress, @phone_number, @e_mail)", student);
            }
        }
        public void SaveGuardian(GuardianModel guardian)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO guardians (first_name, last_name, adress, phone_number, e_mail) " +
                    "VALUES (@first_name, @last_name, @adress, @phone_number, @e_mail)", guardian);
            }
        }

        public void SaveRegistration(StudentModel student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO registration (reg_number, student_id, guardian_id) " +
                    "VALUES (@reg_number, @student_id, @guardian_id)", student);
            }
        }

        public static void RemoveStudent(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM students " +
                    "WHERE id = '" + id + "'");
            }
        }

        public static void RemoveGuardian(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM guardians " +
                    "WHERE id = '" + id + "'");
            }
        }

        public static void ChangeStudent(StudentModel student)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE students " +
                    "SET first_name = '" + student.first_name + "', last_name = '" + student.last_name + "', adress = '" + student.adress + "', phone_number = '" + student.phone_number + "', e_mail = '" + student.e_mail + "'"
                    + "WHERE id = " + student.id);
            }
        }

        public static void ChangeGuardian(GuardianModel guardian)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE guardians " +
                    "SET first_name = '" + guardian.first_name + "', last_name = '" + guardian.last_name + "', adress = '" + guardian.adress + "', phone_number = '" + guardian.phone_number + "', e_mail = '" + guardian.e_mail + "'"
                    + "WHERE id = " + guardian.id);
            }
        }

        public static List<StudentModel> LoadStudents()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<StudentModel>(
                    "SELECT * FROM students", new DynamicParameters());

                return result.ToList();
            }
        }
        public static List<GuardianModel> LoadGuardians()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<GuardianModel>(
                    "SELECT * FROM guardians", new DynamicParameters());

                return result.ToList();
            }
        }
        public static List<ClassModel> LoadClasses()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = cnn.Query<ClassModel>(
                    "SELECT * FROM classes", new DynamicParameters());

                return result.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
