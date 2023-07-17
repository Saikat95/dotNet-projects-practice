using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace library_management_system
{
    public partial class books_stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");
        public books_stock()
        {
            InitializeComponent();
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            fill_gridBookInfo();

        }

        private void fill_gridBookInfo()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book_info";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            grid_bookInfo.DataSource = dt;

            grid_bookInfo.Columns["id"].Visible = false;
        }

        private void grid_bookInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count;
            String book_name = grid_bookInfo.SelectedCells[1].Value.ToString();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select student_rollno,student_name,student_phone,student_mail,student_semester,student_dept,student_address from issue_book where book_name = '" + book_name + "' and return_date = ''";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if(count > 0)
            {
                panel1.Visible = true;
            }

            else
            {
                panel1.Visible = false;
            }

            grid_studentInfo.DataSource = dt;
        }

        private void bookName_to_search_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book_info where book_name like ('%" + bookName_to_search.Text + "%')"; ;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            grid_bookInfo.Columns["id"].Visible = false;

            grid_bookInfo.DataSource = dt;
        }

        private void bookName_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book_info where book_name like ('%" + bookName_to_search.Text + "%')"; ;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            grid_bookInfo.Columns["id"].Visible = false;

            grid_bookInfo.DataSource = dt;
        }

        private void grid_studentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mail = grid_studentInfo.SelectedCells[3].Value.ToString();
            student_mail.Text = mail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "saikatsomraj95@gmail.com";
            nc.Password = "Saikatworks@247";
            smtp.Credentials = nc;

            MailAddress from = new MailAddress("saikatsomraj95@gamil.com", "Saikat Guha");
            MailAddress receiver = new MailAddress("sivisonajeyakodi@gmail.com", "Sivisona Jeyakodi");

            MailMessage message = new MailMessage(from, receiver);
            message.Subject = "Test SMTP server";
            message.Body = "Test Message--> Hello World";

            smtp.Send(message);*/

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("saikatsomraj95@gmail.com", "ohctforhktiuwhlt");
            MailMessage mail = new MailMessage("saikatsomraj95@gmail.com", student_mail.Text , "BOOK RETURN DUE-DATE", mail_body.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Mail Sent");
        }
    }
}
