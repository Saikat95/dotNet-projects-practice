using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace library_management_system
{
    public partial class view_student : Form
    {
        string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        SqlConnection con = new SqlConnection("Data Source=ASUS-SAIKAT;Initial Catalog=library-management-db;Integrated Security=True;Pooling=False");

        public view_student()
        {
            InitializeComponent();
        }

        private void view_student_Load(object sender, EventArgs e)
        {
            load_student_info();
        }

        private void nameSearch_button_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int count;
                int i = 0;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like ('%" + nameInput.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["student_image"].Visible = false;

                Bitmap image;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "student_image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);

                foreach(DataRow dr in dt.Rows)
                {
                    image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[9].Value = image;
                    dataGridView1.Rows[i].Height = 100;
                    i++;
                }

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if(count == 0)
                {
                    MessageBox.Show("Details not available");
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void nameInput_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int count;
                int i = 0;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_name like ('%" + nameInput.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["student_image"].Visible = false;

                Bitmap image;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "student_image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[9].Value = image;
                    dataGridView1.Rows[i].Height = 100;
                    i++;
                }

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count == 0)
                {
                    MessageBox.Show("Name not available");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void rollnoSearch_button_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int count;
                int i = 0;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_rollno like ('%" + rollnoInput.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["student_image"].Visible = false;

                Bitmap image;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "student_image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[9].Value = image;
                    dataGridView1.Rows[i].Height = 100;
                    i++;
                }

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count == 0)
                {
                    MessageBox.Show("Details not available");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void rollnoInput_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int count;
                int i = 0;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where student_rollno like ('%" + rollnoInput.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["student_image"].Visible = false;

                Bitmap image;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.HeaderText = "student_image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageCol.Width = 100;
                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[9].Value = image;
                    dataGridView1.Rows[i].Height = 100;
                    i++;
                }

                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count == 0)
                {
                    MessageBox.Show("Name not available");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void semSearch_button_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    int count;
                    int i = 0;

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from student_info where student_semester like ('%" + semInput.Text + "%')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["student_image"].Visible = false;

                    Bitmap image;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "student_image";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width = 100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                        dataGridView1.Rows[i].Cells[9].Value = image;
                        dataGridView1.Rows[i].Height = 100;
                        i++;
                    }

                    count = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (count == 0)
                    {
                        MessageBox.Show("Details not available");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void deptSearch_button_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    int count;
                    int i = 0;

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from student_info where student_department like ('%" + deptInput.Text + "%')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["student_image"].Visible = false;

                    Bitmap image;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "student_image";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width = 100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                        dataGridView1.Rows[i].Cells[9].Value = image;
                        dataGridView1.Rows[i].Height = 100;
                        i++;
                    }

                    count = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (count == 0)
                    {
                        MessageBox.Show("Details not available");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void addressSearch_button_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();
                    int count;
                    int i = 0;

                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from student_info where student_address like ('%" + addressInput.Text + "%')";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["student_image"].Visible = false;

                    Bitmap image;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "student_image";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width = 100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                        dataGridView1.Rows[i].Cells[9].Value = image;
                        dataGridView1.Rows[i].Height = 100;
                        i++;
                    }

                    count = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (count == 0)
                    {
                        MessageBox.Show("Details not available");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_update.Visible = true;

            try
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where id = '"+i+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    name_update.Text = dr["student_name"].ToString();
                    phone_update.Text = dr["student_phone"].ToString();
                    email_update.Text = dr["student_mail"].ToString();
                    sem_update.Text = dr["student_semester"].ToString();
                    dept_update.Text = dr["student_department"].ToString();
                    address_update.Text = dr["student_address"].ToString();

                    String imagePath = path + "\\" + dr["student_image"].ToString();
                    Bitmap image = new Bitmap(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                    pictureBox1.Image = image;
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                con.Open();

                SqlCommand cmd2 = con.CreateCommand();                
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select student_rollno from student_info where id = '"+i+"'";
                String roll_imageID = (String)cmd2.ExecuteScalar();
                String imageName = name_generator(roll_imageID);
                String image_path_new = "\\StudentImage\\" + imageName + ".jpg";
                Console.WriteLine(image_path_new);

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select student_image from student_info where id = '" + i + "'";
                Console.WriteLine((String)cmd3.ExecuteScalar());
                String image_path_old = (String)cmd3.ExecuteScalar();
                Console.Write(image_path_old);

                File.Copy(openFileDialog1.FileName, path + image_path_new, true);

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update student_info set student_name = '"+name_update.Text+"', student_image = '"+ image_path_new + "', student_phone = '"+phone_update.Text+"', student_mail = '"+email_update.Text+"', student_address = '"+address_update.Text+"', student_semester = '"+sem_update.Text+"', student_department = '"+dept_update.Text+"' where id = '"+i+"'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Updated");

                load_student_info();

                con.Close();

                //File.Move(path+image_path_old, path+"\\StudentImage\\temp\\"+name_generator(roll_imageID) + "_copy"+".jpg");
            }
           
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void load_student_info()
        {
            int i = 0;

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["student_image"].Visible = false;

            Bitmap image;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.HeaderText = "student_image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.Width = 100;
            dataGridView1.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                image = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                dataGridView1.Rows[i].Cells[9].Value = image;
                dataGridView1.Rows[i].Height = 100;
                i++;
            }
        }

        private void update_photo_button_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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
