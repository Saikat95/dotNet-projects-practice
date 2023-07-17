
namespace library_management_system
{
    partial class view_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addressSearch_button = new System.Windows.Forms.Button();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deptSearch_button = new System.Windows.Forms.Button();
            this.deptInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.semSearch_button = new System.Windows.Forms.Button();
            this.semInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rollnoSearch_button = new System.Windows.Forms.Button();
            this.rollnoInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameSearch_button = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.name_update = new System.Windows.Forms.TextBox();
            this.phone_update = new System.Windows.Forms.TextBox();
            this.email_update = new System.Windows.Forms.TextBox();
            this.sem_update = new System.Windows.Forms.TextBox();
            this.dept_update = new System.Windows.Forms.TextBox();
            this.address_update = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update_photo_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1006, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW STUDENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 532);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 544);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addressSearch_button);
            this.panel6.Controls.Add(this.addressInput);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 437);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 96);
            this.panel6.TabIndex = 3;
            // 
            // addressSearch_button
            // 
            this.addressSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressSearch_button.Location = new System.Drawing.Point(172, 50);
            this.addressSearch_button.Name = "addressSearch_button";
            this.addressSearch_button.Size = new System.Drawing.Size(97, 30);
            this.addressSearch_button.TabIndex = 2;
            this.addressSearch_button.Text = "Search";
            this.addressSearch_button.UseVisualStyleBackColor = true;
            this.addressSearch_button.Click += new System.EventHandler(this.addressSearch_button_Click);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(131, 8);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(302, 22);
            this.addressInput.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deptSearch_button);
            this.panel5.Controls.Add(this.deptInput);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(4, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 96);
            this.panel5.TabIndex = 3;
            // 
            // deptSearch_button
            // 
            this.deptSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptSearch_button.Location = new System.Drawing.Point(172, 50);
            this.deptSearch_button.Name = "deptSearch_button";
            this.deptSearch_button.Size = new System.Drawing.Size(96, 30);
            this.deptSearch_button.TabIndex = 2;
            this.deptSearch_button.Text = "Search";
            this.deptSearch_button.UseVisualStyleBackColor = true;
            this.deptSearch_button.Click += new System.EventHandler(this.deptSearch_button_Click);
            // 
            // deptInput
            // 
            this.deptInput.Location = new System.Drawing.Point(130, 8);
            this.deptInput.Name = "deptInput";
            this.deptInput.Size = new System.Drawing.Size(303, 22);
            this.deptInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.semSearch_button);
            this.panel4.Controls.Add(this.semInput);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(4, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 112);
            this.panel4.TabIndex = 3;
            // 
            // semSearch_button
            // 
            this.semSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semSearch_button.Location = new System.Drawing.Point(172, 50);
            this.semSearch_button.Name = "semSearch_button";
            this.semSearch_button.Size = new System.Drawing.Size(96, 30);
            this.semSearch_button.TabIndex = 2;
            this.semSearch_button.Text = "Search";
            this.semSearch_button.UseVisualStyleBackColor = true;
            this.semSearch_button.Click += new System.EventHandler(this.semSearch_button_Click);
            // 
            // semInput
            // 
            this.semInput.Location = new System.Drawing.Point(130, 8);
            this.semInput.Name = "semInput";
            this.semInput.Size = new System.Drawing.Size(303, 22);
            this.semInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Semester";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rollnoSearch_button);
            this.panel3.Controls.Add(this.rollnoInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(4, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 95);
            this.panel3.TabIndex = 3;
            // 
            // rollnoSearch_button
            // 
            this.rollnoSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollnoSearch_button.Location = new System.Drawing.Point(172, 50);
            this.rollnoSearch_button.Name = "rollnoSearch_button";
            this.rollnoSearch_button.Size = new System.Drawing.Size(96, 30);
            this.rollnoSearch_button.TabIndex = 2;
            this.rollnoSearch_button.Text = "Search";
            this.rollnoSearch_button.UseVisualStyleBackColor = true;
            this.rollnoSearch_button.Click += new System.EventHandler(this.rollnoSearch_button_Click);
            // 
            // rollnoInput
            // 
            this.rollnoInput.Location = new System.Drawing.Point(130, 8);
            this.rollnoInput.Name = "rollnoInput";
            this.rollnoInput.Size = new System.Drawing.Size(303, 22);
            this.rollnoInput.TabIndex = 1;
            this.rollnoInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rollnoInput_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Roll No.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameSearch_button);
            this.panel2.Controls.Add(this.nameInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 96);
            this.panel2.TabIndex = 0;
            // 
            // nameSearch_button
            // 
            this.nameSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearch_button.Location = new System.Drawing.Point(172, 40);
            this.nameSearch_button.Name = "nameSearch_button";
            this.nameSearch_button.Size = new System.Drawing.Size(96, 30);
            this.nameSearch_button.TabIndex = 2;
            this.nameSearch_button.Text = "Search";
            this.nameSearch_button.UseVisualStyleBackColor = true;
            this.nameSearch_button.Click += new System.EventHandler(this.nameSearch_button_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(130, 3);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(303, 22);
            this.nameInput.TabIndex = 1;
            this.nameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameInput_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "SEARCH STUDENT";
            // 
            // panel_update
            // 
            this.panel_update.Controls.Add(this.update_button);
            this.panel_update.Controls.Add(this.update_photo_button);
            this.panel_update.Controls.Add(this.pictureBox1);
            this.panel_update.Controls.Add(this.address_update);
            this.panel_update.Controls.Add(this.dept_update);
            this.panel_update.Controls.Add(this.sem_update);
            this.panel_update.Controls.Add(this.email_update);
            this.panel_update.Controls.Add(this.phone_update);
            this.panel_update.Controls.Add(this.name_update);
            this.panel_update.Controls.Add(this.label14);
            this.panel_update.Controls.Add(this.label13);
            this.panel_update.Controls.Add(this.label12);
            this.panel_update.Controls.Add(this.label11);
            this.panel_update.Controls.Add(this.label10);
            this.panel_update.Controls.Add(this.label9);
            this.panel_update.Controls.Add(this.label8);
            this.panel_update.Location = new System.Drawing.Point(12, 622);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(1740, 399);
            this.panel_update.TabIndex = 3;
            this.panel_update.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1159, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "EDIT DETAILS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(759, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(760, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1242, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Semester";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1242, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Department";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1242, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "Address";
            // 
            // name_update
            // 
            this.name_update.Location = new System.Drawing.Point(845, 60);
            this.name_update.Name = "name_update";
            this.name_update.Size = new System.Drawing.Size(355, 22);
            this.name_update.TabIndex = 7;
            // 
            // phone_update
            // 
            this.phone_update.Location = new System.Drawing.Point(845, 180);
            this.phone_update.Name = "phone_update";
            this.phone_update.Size = new System.Drawing.Size(355, 22);
            this.phone_update.TabIndex = 8;
            // 
            // email_update
            // 
            this.email_update.Location = new System.Drawing.Point(845, 302);
            this.email_update.Name = "email_update";
            this.email_update.Size = new System.Drawing.Size(355, 22);
            this.email_update.TabIndex = 9;
            // 
            // sem_update
            // 
            this.sem_update.Location = new System.Drawing.Point(1361, 62);
            this.sem_update.Name = "sem_update";
            this.sem_update.Size = new System.Drawing.Size(372, 22);
            this.sem_update.TabIndex = 10;
            // 
            // dept_update
            // 
            this.dept_update.Location = new System.Drawing.Point(1361, 176);
            this.dept_update.Name = "dept_update";
            this.dept_update.Size = new System.Drawing.Size(372, 22);
            this.dept_update.TabIndex = 11;
            // 
            // address_update
            // 
            this.address_update.Location = new System.Drawing.Point(1361, 306);
            this.address_update.Name = "address_update";
            this.address_update.Size = new System.Drawing.Size(372, 22);
            this.address_update.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(463, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 234);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // update_photo_button
            // 
            this.update_photo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_photo_button.Location = new System.Drawing.Point(526, 306);
            this.update_photo_button.Name = "update_photo_button";
            this.update_photo_button.Size = new System.Drawing.Size(75, 31);
            this.update_photo_button.TabIndex = 14;
            this.update_photo_button.Text = "Upload";
            this.update_photo_button.UseVisualStyleBackColor = true;
            this.update_photo_button.Click += new System.EventHandler(this.update_photo_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(1164, 358);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(141, 38);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // view_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 1033);
            this.Controls.Add(this.panel_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "view_student";
            this.Text = "View Student";
            this.Load += new System.EventHandler(this.view_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button addressSearch_button;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deptSearch_button;
        private System.Windows.Forms.TextBox deptInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button semSearch_button;
        private System.Windows.Forms.TextBox semInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button rollnoSearch_button;
        private System.Windows.Forms.TextBox rollnoInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nameSearch_button;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_update;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button update_photo_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox address_update;
        private System.Windows.Forms.TextBox dept_update;
        private System.Windows.Forms.TextBox sem_update;
        private System.Windows.Forms.TextBox email_update;
        private System.Windows.Forms.TextBox phone_update;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}