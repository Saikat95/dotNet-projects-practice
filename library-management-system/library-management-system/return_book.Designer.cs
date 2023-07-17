
namespace library_management_system
{
    partial class return_book
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
            this.rollno_to_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.book_info_grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.return_date_picker = new System.Windows.Forms.DateTimePicker();
            this.submit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.TextBox();
            this.author_name = new System.Windows.Forms.TextBox();
            this.issue_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.book_info_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollno_to_search
            // 
            this.rollno_to_search.Location = new System.Drawing.Point(25, 140);
            this.rollno_to_search.Name = "rollno_to_search";
            this.rollno_to_search.Size = new System.Drawing.Size(299, 22);
            this.rollno_to_search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Roll No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "RETURN BOOK";
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(121, 168);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(85, 34);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // book_info_grid
            // 
            this.book_info_grid.AllowUserToAddRows = false;
            this.book_info_grid.AllowUserToDeleteRows = false;
            this.book_info_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_info_grid.Location = new System.Drawing.Point(349, 67);
            this.book_info_grid.Name = "book_info_grid";
            this.book_info_grid.RowHeadersWidth = 51;
            this.book_info_grid.RowTemplate.Height = 24;
            this.book_info_grid.Size = new System.Drawing.Size(879, 277);
            this.book_info_grid.TabIndex = 4;
            this.book_info_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_info_grid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.issue_date);
            this.panel1.Controls.Add(this.author_name);
            this.panel1.Controls.Add(this.book_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.return_date_picker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(79, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 210);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(789, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Return Date";
            // 
            // return_date_picker
            // 
            this.return_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.return_date_picker.Location = new System.Drawing.Point(547, 107);
            this.return_date_picker.Name = "return_date_picker";
            this.return_date_picker.Size = new System.Drawing.Size(106, 22);
            this.return_date_picker.TabIndex = 6;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(461, 162);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(171, 45);
            this.submit_button.TabIndex = 7;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Author Name";
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(114, 50);
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Size = new System.Drawing.Size(235, 22);
            this.book_name.TabIndex = 9;
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(487, 50);
            this.author_name.Name = "author_name";
            this.author_name.ReadOnly = true;
            this.author_name.Size = new System.Drawing.Size(275, 22);
            this.author_name.TabIndex = 10;
            // 
            // issue_date
            // 
            this.issue_date.Location = new System.Drawing.Point(880, 48);
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            this.issue_date.Size = new System.Drawing.Size(225, 22);
            this.issue_date.TabIndex = 11;
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.book_info_grid);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rollno_to_search);
            this.Name = "return_book";
            this.Text = "return_book";
            this.Load += new System.EventHandler(this.return_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.book_info_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rollno_to_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView book_info_grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.DateTimePicker return_date_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox issue_date;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.TextBox book_name;
    }
}