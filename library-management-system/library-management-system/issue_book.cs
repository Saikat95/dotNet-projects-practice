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

namespace library_management_system
{
    public partial class issue_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");

        public issue_book()
        {
            InitializeComponent();
        }

        private void issue_book_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
        }

        private void rollno_to_search_KeyUp(object sender, KeyEventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            int count = 0;

            if(e.KeyCode != Keys.Enter)
            {
                rollno_list.Items.Clear();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_rollno like ('%"+rollno_to_search.Text+"%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    rollno_list.Visible = true;

                    foreach(DataRow dr in dt.Rows)
                    {
                        rollno_list.Items.Add(dr["student_rollno"].ToString());
                    }
                }
                
            }

            
        }

        private void rollno_to_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                rollno_list.Focus();
                rollno_list.SelectedIndex = 0;
                if (rollno_list.Focus())
                {
                    rollno_to_search.Text = rollno_list.SelectedItem.ToString();
                }
            }
        }

        private void rollno_list_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                rollno_to_search.Text = rollno_list.SelectedItem.ToString();
                rollno_list.Visible = false;
            }
        }

        private void rollno_list_MouseClick(object sender, MouseEventArgs e)
        {
            rollno_to_search.Text = rollno_list.SelectedItem.ToString();
            rollno_list.Visible = false;
        }

        private void rollno_list_MouseHover(object sender, EventArgs e)
        {
            rollno_list.Focus();
        }

        private void search_student_button_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            int count = 0;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_rollno like ('%"+rollno_to_search.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                foreach(DataRow dr in dt.Rows)
                {
                    student_rollno.Text = dr["student_rollno"].ToString();
                    student_name.Text = dr["student_name"].ToString();
                    student_dept.Text = dr["student_department"].ToString();
                    student_sem.Text = dr["student_semester"].ToString();
                    student_contact.Text = dr["student_phone"].ToString();
                    student_email.Text = dr["student_mail"].ToString();
                    student_address.Text = dr["student_address"].ToString();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bookName_to_search_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            bookName_list.Items.Clear();

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            if(e.KeyCode != Keys.Enter)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_name like ('%"+bookName_to_search.Text+"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                Console.WriteLine(count);

                if(count > 0)
                {
                    bookName_list.Visible = true;

                    foreach(DataRow dr in dt.Rows)
                    {
                        bookName_list.Items.Add(dr["book_name"].ToString());
                    }
                }
            }
        }

        private void bookName_to_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                bookName_list.Focus();
                bookName_list.SelectedIndex = 0;
                if (bookName_list.Focus())
                {
                    bookName_to_search.Text = bookName_list.SelectedItem.ToString();
                }
            }
        }

        private void bookName_list_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bookName_to_search.Text = bookName_list.SelectedItem.ToString();
                bookName_list.Visible = false;
            }
        }

        private void bookName_list_MouseClick(object sender, MouseEventArgs e)
        {
            bookName_to_search.Text = bookName_list.SelectedItem.ToString();
            bookName_list.Visible = false;
        }

        private void search_book_button_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_name like ('%"+bookName_to_search.Text+"%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    book_id.Text = dr["id"].ToString();
                    book_name.Text = dr["book_name"].ToString();
                    book_author.Text = dr["book_author_name"].ToString();
                    book_publication.Text = dr["book_publication_name"].ToString();
                    book_price.Text = dr["book_price"].ToString();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select book_quantity from book_info where book_name = '"+bookName_to_search.Text+"'";
            int quantity_left = Convert.ToInt32(cmd2.ExecuteScalar());

            if(quantity_left != 0)
            {
                
                    try
                    {
                
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into issue_book values('"+student_name.Text+"','"+student_rollno.Text+"','"+student_contact.Text+"','"+student_email.Text+"','"+student_address.Text+"','"+student_sem.Text+"','"+student_dept.Text+"','"+book_id.Text+"','"+book_name.Text+"','"+book_author.Text+"','"+book_publication.Text+"','"+book_price.Text+"','"+issue_date.Text+"','')";
                        cmd.ExecuteNonQuery();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    try
                    {
                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update book_info set book_quantity = book_quantity-1 where book_name = '"+bookName_to_search.Text+"'";
                        cmd1.ExecuteNonQuery();
                    }
            
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    con.Close();

                    MessageBox.Show("Book Issued Successfully");
                    student_name.Text = "";
                    student_rollno.Text = "";
                    student_dept.Text = "";
                    student_sem.Text = "";
                    student_contact.Text = "";
                    student_email.Text = "";
                    student_address.Text = "";
                    book_id.Text = "";
                    book_name.Text = "";
                    book_author.Text = "";
                    book_publication.Text = "";
                    book_price.Text = "";
                    issue_date.Text = "";

            }

            else
            {
                MessageBox.Show("Book Not Available in Stock");
                bookName_to_search.Text = "";
                book_id.Text = "";
                book_name.Text = "";
                book_author.Text = "";
                book_publication.Text = "";
                book_price.Text = "";
                issue_date.Text = "";
            }

            
        }
    }
}
