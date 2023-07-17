using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace library_management_system
{
    public partial class add_student : Form
    {
        string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");
        public add_student()
        {
            InitializeComponent();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string imageName = name_generator(rollno_input.Text);
            File.Copy(openFileDialog1.FileName, path + "\\StudentImage\\" + imageName +".jpg");
            string image_path = "\\StudentImage\\" + imageName + ".jpg";

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into student_info values ('"+name_input.Text+"','"+image_path+"','"+rollno_input.Text+"','"+phone_input.Text+"','"+email_input.Text+"','"+address_input.Text+"','"+sem_input.Text+"','"+dept_input.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            name_input.Text = "";
            image_path = "";
            rollno_input.Text = "";
            phone_input.Text = ""; 
            email_input.Text = "";
            address_input.Text = "";
            sem_input.Text = "";
            dept_input.Text = "";
            pictureBox1.Image = null;

            MessageBox.Show("Student Details Addedd Successfully");
        }

        private string name_generator(string rollID)
        {
            string result;
            string dateTime = DateTime.Now.ToString("ddMMyyyyhhmmss");
            result = rollID + "_" + dateTime;

            return result;
        }

    }
}
