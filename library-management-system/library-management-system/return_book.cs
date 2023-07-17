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
    public partial class return_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");

        public return_book()
        {
            InitializeComponent();
        }

        private void return_book_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            grid_load();
        }

        private void book_info_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            try
            {
                int i = Convert.ToInt32(book_info_grid.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from issue_book where id = '"+i+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    book_name.Text = dr["book_name"].ToString();
                    author_name.Text = dr["book_author"].ToString();
                    issue_date.Text = dr["issue_date"].ToString();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update issue_book set return_date = '" +return_date_picker.Text+ "' where book_name = '" +book_name.Text+ "'";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update book_info set book_quantity = book_quantity + 1 where book_name = '" +book_name.Text+ "'";
                cmd.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Book Returned on: ", return_date_picker.Text.ToString());

            grid_load();
            panel1.Visible = false;
        }

        private void grid_load()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from issue_book where student_rollno = '" + rollno_to_search.Text + "' and return_date = ''";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                book_info_grid.DataSource = dt;
                book_info_grid.Columns["id"].Visible = false;
                book_info_grid.Columns["student_name"].Visible = false;
                book_info_grid.Columns["student_rollno"].Visible = false;
                book_info_grid.Columns["student_phone"].Visible = false;
                book_info_grid.Columns["student_mail"].Visible = false;
                book_info_grid.Columns["student_address"].Visible = false;
                book_info_grid.Columns["student_semester"].Visible = false;
                book_info_grid.Columns["student_dept"].Visible = false;
                book_info_grid.Columns["return_date"].Visible = false;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
