using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing.Drawing2D;


namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    class STUDENT
    {
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime bdate { get; set; }
        public bool gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public Image pic { get; set; }
        public STUDENT()   //Tạo student rỗng để chạy k lỗi với khởi tạo Student để add vào List
        {

        }
        public STUDENT(int a, string b, string c, DateTime d, bool e, string f, string k, Image n)
        {
            this.Id = a;
            this.fname = b;
            this.lname = c;
            this.bdate = d;
            this.gender = e;
            this.phone = f;
            this.address = k;
            this.pic = n;
        }
        MY_DB mydb = new MY_DB();

        //function to insert a new student
        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture )
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic) ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool DeleteStudent (int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = " + id, mydb.getConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public bool EditStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET  fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, address=@adrs, picture=@pic WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //day05
        //function to get all the students form databases

        public List<string> convert()  // Convert dữ liệu trong List Student sang String, từ Id Gender đều sang String 
        {
            List<string> stnew = new List<string>(); // Create new list of strings
            string a = Convert.ToString(Id);
            string b = Convert.ToString(fname);
            string c = Convert.ToString(lname);
            string d = Convert.ToString(bdate);
            string e = Convert.ToString(gender);
            string f = Convert.ToString(phone);
            string g = Convert.ToString(address);

            if (e == "False")
            {
                e = "Female";
            }
            if (e == "True")
            {
                e = "Male";
            }
            stnew.Add(a);
            stnew.Add(b); stnew.Add(c); stnew.Add(d); stnew.Add(e); stnew.Add(f); stnew.Add(g);
            return stnew;
        }
        public DataTable getStudents (SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM STD");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Female'");
        }
        
    }
}
