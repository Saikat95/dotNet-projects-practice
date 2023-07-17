
namespace library_management_system
{
    partial class books_stock
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
            this.grid_bookInfo = new System.Windows.Forms.DataGridView();
            this.grid_studentInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookName_to_search = new System.Windows.Forms.TextBox();
            this.bookName_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_mail = new System.Windows.Forms.TextBox();
            this.mail_body = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_studentInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_bookInfo
            // 
            this.grid_bookInfo.AllowUserToAddRows = false;
            this.grid_bookInfo.AllowUserToDeleteRows = false;
            this.grid_bookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_bookInfo.Location = new System.Drawing.Point(554, 64);
            this.grid_bookInfo.Name = "grid_bookInfo";
            this.grid_bookInfo.RowHeadersWidth = 51;
            this.grid_bookInfo.RowTemplate.Height = 24;
            this.grid_bookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_bookInfo.Size = new System.Drawing.Size(870, 248);
            this.grid_bookInfo.TabIndex = 0;
            this.grid_bookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_bookInfo_CellClick);
            // 
            // grid_studentInfo
            // 
            this.grid_studentInfo.AllowUserToAddRows = false;
            this.grid_studentInfo.AllowUserToDeleteRows = false;
            this.grid_studentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_studentInfo.Location = new System.Drawing.Point(542, 41);
            this.grid_studentInfo.Name = "grid_studentInfo";
            this.grid_studentInfo.RowHeadersWidth = 51;
            this.grid_studentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_studentInfo.Size = new System.Drawing.Size(870, 299);
            this.grid_studentInfo.TabIndex = 1;
            this.grid_studentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_studentInfo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOOKS STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name";
            // 
            // bookName_to_search
            // 
            this.bookName_to_search.Location = new System.Drawing.Point(79, 109);
            this.bookName_to_search.Name = "bookName_to_search";
            this.bookName_to_search.Size = new System.Drawing.Size(356, 22);
            this.bookName_to_search.TabIndex = 4;
            this.bookName_to_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookName_to_search_KeyUp);
            // 
            // bookName_search
            // 
            this.bookName_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName_search.Location = new System.Drawing.Point(197, 151);
            this.bookName_search.Name = "bookName_search";
            this.bookName_search.Size = new System.Drawing.Size(101, 32);
            this.bookName_search.TabIndex = 5;
            this.bookName_search.Text = "Search";
            this.bookName_search.UseVisualStyleBackColor = true;
            this.bookName_search.Click += new System.EventHandler(this.bookName_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mail_body);
            this.panel1.Controls.Add(this.student_mail);
            this.panel1.Controls.Add(this.grid_studentInfo);
            this.panel1.Location = new System.Drawing.Point(12, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 343);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // student_mail
            // 
            this.student_mail.Location = new System.Drawing.Point(185, 41);
            this.student_mail.Name = "student_mail";
            this.student_mail.Size = new System.Drawing.Size(337, 22);
            this.student_mail.TabIndex = 2;
            // 
            // mail_body
            // 
            this.mail_body.Location = new System.Drawing.Point(185, 97);
            this.mail_body.Multiline = true;
            this.mail_body.Name = "mail_body";
            this.mail_body.Size = new System.Drawing.Size(337, 192);
            this.mail_body.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail Body";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookName_search);
            this.Controls.Add(this.bookName_to_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_bookInfo);
            this.Name = "books_stock";
            this.Text = "books_stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_bookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_studentInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_bookInfo;
        private System.Windows.Forms.DataGridView grid_studentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookName_to_search;
        private System.Windows.Forms.Button bookName_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mail_body;
        private System.Windows.Forms.TextBox student_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}