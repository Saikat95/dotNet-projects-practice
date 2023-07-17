
namespace library_management_system
{
    partial class issue_book
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_rollno = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.TextBox();
            this.bookName_list = new System.Windows.Forms.ListBox();
            this.rollno_list = new System.Windows.Forms.ListBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.search_book_button = new System.Windows.Forms.Button();
            this.search_student_button = new System.Windows.Forms.Button();
            this.issue_date = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.book_price = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.book_publication = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.book_author = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bookName_to_search = new System.Windows.Forms.TextBox();
            this.student_address = new System.Windows.Forms.TextBox();
            this.student_email = new System.Windows.Forms.TextBox();
            this.student_contact = new System.Windows.Forms.TextBox();
            this.student_sem = new System.Windows.Forms.TextBox();
            this.student_dept = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.TextBox();
            this.rollno_to_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.student_rollno);
            this.panel1.Controls.Add(this.book_id);
            this.panel1.Controls.Add(this.bookName_list);
            this.panel1.Controls.Add(this.rollno_list);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.search_book_button);
            this.panel1.Controls.Add(this.search_student_button);
            this.panel1.Controls.Add(this.issue_date);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.book_price);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.book_publication);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.book_author);
            this.panel1.Controls.Add(this.book_name);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.bookName_to_search);
            this.panel1.Controls.Add(this.student_address);
            this.panel1.Controls.Add(this.student_email);
            this.panel1.Controls.Add(this.student_contact);
            this.panel1.Controls.Add(this.student_sem);
            this.panel1.Controls.Add(this.student_dept);
            this.panel1.Controls.Add(this.student_name);
            this.panel1.Controls.Add(this.rollno_to_search);
            this.panel1.Location = new System.Drawing.Point(55, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1441, 713);
            this.panel1.TabIndex = 0;
            // 
            // student_rollno
            // 
            this.student_rollno.Location = new System.Drawing.Point(311, 651);
            this.student_rollno.Name = "student_rollno";
            this.student_rollno.ReadOnly = true;
            this.student_rollno.Size = new System.Drawing.Size(108, 22);
            this.student_rollno.TabIndex = 37;
            this.student_rollno.Visible = false;
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(1075, 473);
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Size = new System.Drawing.Size(100, 22);
            this.book_id.TabIndex = 36;
            this.book_id.Visible = false;
            // 
            // bookName_list
            // 
            this.bookName_list.FormattingEnabled = true;
            this.bookName_list.ItemHeight = 16;
            this.bookName_list.Location = new System.Drawing.Point(984, 78);
            this.bookName_list.Name = "bookName_list";
            this.bookName_list.Size = new System.Drawing.Size(282, 84);
            this.bookName_list.TabIndex = 34;
            this.bookName_list.Visible = false;
            this.bookName_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bookName_list_MouseClick);
            this.bookName_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookName_list_KeyDown);
            // 
            // rollno_list
            // 
            this.rollno_list.FormattingEnabled = true;
            this.rollno_list.ItemHeight = 16;
            this.rollno_list.Location = new System.Drawing.Point(193, 78);
            this.rollno_list.Name = "rollno_list";
            this.rollno_list.Size = new System.Drawing.Size(282, 84);
            this.rollno_list.TabIndex = 33;
            this.rollno_list.Visible = false;
            this.rollno_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rollno_list_MouseClick);
            this.rollno_list.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rollno_list_KeyUp);
            this.rollno_list.MouseHover += new System.EventHandler(this.rollno_list_MouseHover);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(1062, 602);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(160, 48);
            this.submit_button.TabIndex = 32;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // search_book_button
            // 
            this.search_book_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_book_button.Location = new System.Drawing.Point(1072, 89);
            this.search_book_button.Name = "search_book_button";
            this.search_book_button.Size = new System.Drawing.Size(91, 32);
            this.search_book_button.TabIndex = 31;
            this.search_book_button.Text = "Search";
            this.search_book_button.UseVisualStyleBackColor = true;
            this.search_book_button.Click += new System.EventHandler(this.search_book_button_Click);
            // 
            // search_student_button
            // 
            this.search_student_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_student_button.Location = new System.Drawing.Point(283, 89);
            this.search_student_button.Name = "search_student_button";
            this.search_student_button.Size = new System.Drawing.Size(91, 32);
            this.search_student_button.TabIndex = 30;
            this.search_student_button.Text = "Search";
            this.search_student_button.UseVisualStyleBackColor = true;
            this.search_student_button.Click += new System.EventHandler(this.search_student_button_Click);
            // 
            // issue_date
            // 
            this.issue_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issue_date.Location = new System.Drawing.Point(1075, 515);
            this.issue_date.Name = "issue_date";
            this.issue_date.Size = new System.Drawing.Size(108, 22);
            this.issue_date.TabIndex = 29;
            this.issue_date.Value = new System.DateTime(2023, 7, 6, 22, 13, 7, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(875, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Issue Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(871, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Book Price";
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(1075, 445);
            this.book_price.Name = "book_price";
            this.book_price.ReadOnly = true;
            this.book_price.Size = new System.Drawing.Size(282, 22);
            this.book_price.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(871, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Publication Name";
            // 
            // book_publication
            // 
            this.book_publication.Location = new System.Drawing.Point(1075, 380);
            this.book_publication.Name = "book_publication";
            this.book_publication.ReadOnly = true;
            this.book_publication.Size = new System.Drawing.Size(282, 22);
            this.book_publication.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(871, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Author Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(871, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Book Name";
            // 
            // book_author
            // 
            this.book_author.Location = new System.Drawing.Point(1075, 314);
            this.book_author.Name = "book_author";
            this.book_author.ReadOnly = true;
            this.book_author.Size = new System.Drawing.Size(282, 22);
            this.book_author.TabIndex = 21;
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(1075, 259);
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Size = new System.Drawing.Size(282, 22);
            this.book_name.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1058, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Book Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(269, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Student Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1043, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Enter Book Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(941, 713);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Issue Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Student Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Student Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Dept.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Roll Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1075, 711);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // bookName_to_search
            // 
            this.bookName_to_search.Location = new System.Drawing.Point(984, 50);
            this.bookName_to_search.Name = "bookName_to_search";
            this.bookName_to_search.Size = new System.Drawing.Size(282, 22);
            this.bookName_to_search.TabIndex = 7;
            this.bookName_to_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookName_to_search_KeyDown);
            this.bookName_to_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookName_to_search_KeyUp);
            // 
            // student_address
            // 
            this.student_address.Location = new System.Drawing.Point(311, 602);
            this.student_address.Name = "student_address";
            this.student_address.ReadOnly = true;
            this.student_address.Size = new System.Drawing.Size(282, 22);
            this.student_address.TabIndex = 6;
            // 
            // student_email
            // 
            this.student_email.Location = new System.Drawing.Point(311, 528);
            this.student_email.Name = "student_email";
            this.student_email.ReadOnly = true;
            this.student_email.Size = new System.Drawing.Size(282, 22);
            this.student_email.TabIndex = 5;
            // 
            // student_contact
            // 
            this.student_contact.Location = new System.Drawing.Point(311, 454);
            this.student_contact.Name = "student_contact";
            this.student_contact.ReadOnly = true;
            this.student_contact.Size = new System.Drawing.Size(282, 22);
            this.student_contact.TabIndex = 4;
            // 
            // student_sem
            // 
            this.student_sem.Location = new System.Drawing.Point(311, 382);
            this.student_sem.Name = "student_sem";
            this.student_sem.ReadOnly = true;
            this.student_sem.Size = new System.Drawing.Size(282, 22);
            this.student_sem.TabIndex = 3;
            // 
            // student_dept
            // 
            this.student_dept.Location = new System.Drawing.Point(311, 312);
            this.student_dept.Name = "student_dept";
            this.student_dept.ReadOnly = true;
            this.student_dept.Size = new System.Drawing.Size(282, 22);
            this.student_dept.TabIndex = 2;
            // 
            // student_name
            // 
            this.student_name.Location = new System.Drawing.Point(311, 257);
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Size = new System.Drawing.Size(282, 22);
            this.student_name.TabIndex = 1;
            // 
            // rollno_to_search
            // 
            this.rollno_to_search.Location = new System.Drawing.Point(193, 50);
            this.rollno_to_search.Name = "rollno_to_search";
            this.rollno_to_search.Size = new System.Drawing.Size(282, 22);
            this.rollno_to_search.TabIndex = 0;
            this.rollno_to_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rollno_to_search_KeyDown);
            this.rollno_to_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rollno_to_search_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISSUE BOOK";
            // 
            // issue_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "issue_book";
            this.Text = "issue_book";
            this.Load += new System.EventHandler(this.issue_book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox book_price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox book_publication;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox book_author;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox bookName_to_search;
        private System.Windows.Forms.TextBox student_address;
        private System.Windows.Forms.TextBox student_email;
        private System.Windows.Forms.TextBox student_contact;
        private System.Windows.Forms.TextBox student_sem;
        private System.Windows.Forms.TextBox student_dept;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.TextBox rollno_to_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button search_book_button;
        private System.Windows.Forms.Button search_student_button;
        private System.Windows.Forms.DateTimePicker issue_date;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox bookName_list;
        private System.Windows.Forms.ListBox rollno_list;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.TextBox student_rollno;
    }
}