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
    public partial class add_book : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");
        public add_book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into book_info values('"+book_name.Text+"','"+author_name.Text+"','"+publication_name.Text+"','"+dateTimePicker.Text+"','"+book_price.Text+"','"+book_quanity.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            book_name.Text = "";
            author_name.Text = "";
            publication_name.Text = "";
            dateTimePicker.Text = "";
            book_price.Text = "";
            book_quanity.Text = "";

            MessageBox.Show("Details Added Successfully");
        }
    }
}
