using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    class COURSE
    {
        MY_DB db = new MY_DB();

        //CREATE A FUNCTION TO ADD COURSE
        public bool insertCourse(int id, string label, int hour, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, hours, description)" +
                "VALUES (@id, @lbl, @hrs, @dct) ", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@lbl", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hour;
            command.Parameters.Add("@dct", SqlDbType.Text).Value = description;


            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //function to check out if the course name already exist in the database
        public bool checkUserName(string courseName)
        {
            //SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label = @lbl", db.getConnection);
            command.Parameters.Add("@lbl", SqlDbType.VarChar).Value = courseName;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCoursesById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //delete
        public bool DeleteCourse(int id)
        {

            SqlCommand command = new SqlCommand("DELETE FROM course WHERE Id = @id", db.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
        //function to get all course
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        //edit
        public bool EditCourse(int id, string label, int hour, string description)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET label = @lbl, hours = @hrs, description = @dct WHERE Id=@id", db.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@lbl", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hour;
            command.Parameters.Add("@dct", SqlDbType.VarChar).Value = description;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        //excecount
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, db.getConnection);
            db.openConnection();
            string count = command.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }
        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM course");

        }
    }
    }
