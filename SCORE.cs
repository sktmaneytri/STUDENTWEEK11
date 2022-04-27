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
    class SCORE
    {
        // 
        MY_DB db = new MY_DB();
        //insert socre
        public bool insertScore(int id, int studentid, int courseid, float score, string description)
        {

            SqlCommand command = new SqlCommand("INSERT INTO score (id, studentid, courseid, score, description)" +
                "VALUES (@id, @stid, @cid, @scr, @dct) ", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = score;
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
        //function to check the score exists
        public bool checkScoreExist (int studentid, int courseid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE studentid = @stid AND courseid = @cid", db.getConnection);
            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //create a function to get student score
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;

            command.CommandText = ("SELECT score.studentid,std.fname, std.lname, score.courseid, course.label,score.score FROM std INNER JOIN score ON std.id = score.studentid INNER JOIN course ON score.courseid = course.id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to delete score
        public bool DeleteScore(int studentid, int courseid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE studentid = @stdid AND courseid = @cid", db.getConnection);
            command.Parameters.Add("@stdid", SqlDbType.Int).Value = studentid;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseid;
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
        public DataTable avgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;

            command.CommandText = ("SELECT course.label, avg(score.score) as 'Average Score' FROM course, score " +
                "WHERE course.id = score.courseid GROUP BY course.label");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseScores(int courseid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;

            command.CommandText = ("SELECT score.studentid, std.fname, std.lname, score.courseid, course.label, score.score" +
                " FROM std INNER JOIN score ON std.id = score.studentid INNER JOIN course ON score.courseid = course.id WHERE score.courseid ="
                + courseid);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentScores(int studentid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = db.getConnection;

            command.CommandText = ("SELECT score.studentid, std.fname, std.lname, score.courseid, course.label, score.score" +
                " FROM std INNER JOIN score ON std.id = score.studentid INNER JOIN course ON score.courseid = course.id WHERE score.studentid ="
                + studentid);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getScore(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
