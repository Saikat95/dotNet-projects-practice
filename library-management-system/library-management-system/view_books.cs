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
using System.Globalization;

namespace library_management_system
{
    public partial class view_books : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");

        public view_books()
        {
            InitializeComponent();
        }

        private void view_books_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void bookName_search_Click(object sender, EventArgs e)
        {
            int count;

            try {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_name like('%" +bookName_input.Text+ "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                con.Close();

                if(count == 0)
                {
                    MessageBox.Show("Data Not Available");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error"+ ex);
            }
        }

        private void bookName_input_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_name like('%" + bookName_input.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void authorName_search_Click(object sender, EventArgs e)
        {
            int count;
            try {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_author_name like('%" +authorName_input.Text+ "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                count = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if(count == 0)
                {
                    MessageBox.Show("Data not Available");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void authorName_input_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where book_author_name like('%" + authorName_input.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void publicationDate_search_Click(object sender, EventArgs e)
        {
            int count;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info;";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DataTable dt2 = new DataTable();

                dt2 = dt.Clone();
                dt2.Rows.Clear();

                count = Convert.ToInt32(dt.Rows.Count.ToString());
                string dateSearch = purchaseDate_input.Text;

                foreach(DataRow dr in dt.Rows)
                {
                    var dateFromSQL = dr["book_purchase_date"];
                    var dateToString = dateFromSQL.ToString().Substring(0,9);

                    if(dateSearch == dateToString)
                    {
                        dt2.Rows.Add(dr.ItemArray);
                    }
                }
                
                dataGridView1.DataSource = dt2;
                
                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("Data not Available");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_update.Visible = true;
            
            try
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info where id = "+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    update_bookName.Text = dr["book_name"].ToString();
                    update_authorName.Text = dr["book_author_name"].ToString();
                    update_publicationName.Text = dr["book_publication_name"].ToString();
                    update_purchaseDate.Text = dr["book_purchase_date"].ToString();
                    update_bookPrice.Text = dr["book_price"].ToString();
                    update_bookQuantity.Text = dr["book_quantity"].ToString();
                }

                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update book_info set book_name = '"+update_bookName.Text+"',book_author_name = '"+update_authorName.Text+"',book_publication_name = '"+update_publicationName.Text+"',book_purchase_date = '"+update_purchaseDate.Text+"',book_price = '"+update_bookPrice.Text+"',book_quantity = '"+update_bookQuantity.Text+"' where id = '"+i+"';";
                cmd.ExecuteNonQuery();
                con.Close();
                panel_update.Visible = false;
                MessageBox.Show("Details Updated");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

            loadGridView();
        }

        private void loadGridView()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from book_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}