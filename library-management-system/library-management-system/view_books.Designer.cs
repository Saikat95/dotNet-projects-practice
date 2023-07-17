
namespace library_management_system
{
    partial class view_books
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookName_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bookName_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.authorName_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.authorName_input = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.purchaseDate_input = new System.Windows.Forms.DateTimePicker();
            this.publicationDate_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_update = new System.Windows.Forms.Panel();
            this.update_button = new System.Windows.Forms.Button();
            this.update_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.update_bookQuantity = new System.Windows.Forms.TextBox();
            this.update_bookPrice = new System.Windows.Forms.TextBox();
            this.update_publicationName = new System.Windows.Forms.TextBox();
            this.update_authorName = new System.Windows.Forms.TextBox();
            this.update_bookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(843, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIEW BOOKS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookName_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bookName_input);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 118);
            this.panel1.TabIndex = 2;
            // 
            // bookName_search
            // 
            this.bookName_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName_search.Location = new System.Drawing.Point(139, 76);
            this.bookName_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookName_search.Name = "bookName_search";
            this.bookName_search.Size = new System.Drawing.Size(93, 30);
            this.bookName_search.TabIndex = 2;
            this.bookName_search.Text = "Search";
            this.bookName_search.UseVisualStyleBackColor = true;
            this.bookName_search.Click += new System.EventHandler(this.bookName_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // bookName_input
            // 
            this.bookName_input.Location = new System.Drawing.Point(123, 31);
            this.bookName_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookName_input.Name = "bookName_input";
            this.bookName_input.Size = new System.Drawing.Size(247, 22);
            this.bookName_input.TabIndex = 0;
            this.bookName_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bookName_input_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEARCH BOOKS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.authorName_search);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.authorName_input);
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 127);
            this.panel2.TabIndex = 3;
            // 
            // authorName_search
            // 
            this.authorName_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName_search.Location = new System.Drawing.Point(139, 78);
            this.authorName_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorName_search.Name = "authorName_search";
            this.authorName_search.Size = new System.Drawing.Size(93, 30);
            this.authorName_search.TabIndex = 2;
            this.authorName_search.Text = "Search";
            this.authorName_search.UseVisualStyleBackColor = true;
            this.authorName_search.Click += new System.EventHandler(this.authorName_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Author Name";
            // 
            // authorName_input
            // 
            this.authorName_input.Location = new System.Drawing.Point(123, 28);
            this.authorName_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorName_input.Name = "authorName_input";
            this.authorName_input.Size = new System.Drawing.Size(247, 22);
            this.authorName_input.TabIndex = 0;
            this.authorName_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.authorName_input_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.purchaseDate_input);
            this.panel3.Controls.Add(this.publicationDate_search);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(13, 292);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 127);
            this.panel3.TabIndex = 4;
            // 
            // purchaseDate_input
            // 
            this.purchaseDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDate_input.Location = new System.Drawing.Point(139, 31);
            this.purchaseDate_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purchaseDate_input.Name = "purchaseDate_input";
            this.purchaseDate_input.Size = new System.Drawing.Size(121, 22);
            this.purchaseDate_input.TabIndex = 2;
            this.purchaseDate_input.Value = new System.DateTime(2023, 5, 25, 11, 29, 42, 0);
            // 
            // publicationDate_search
            // 
            this.publicationDate_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationDate_search.Location = new System.Drawing.Point(139, 78);
            this.publicationDate_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicationDate_search.Name = "publicationDate_search";
            this.publicationDate_search.Size = new System.Drawing.Size(93, 30);
            this.publicationDate_search.TabIndex = 2;
            this.publicationDate_search.Text = "Search";
            this.publicationDate_search.UseVisualStyleBackColor = true;
            this.publicationDate_search.Click += new System.EventHandler(this.publicationDate_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Purchase Date";
            // 
            // panel_update
            // 
            this.panel_update.Controls.Add(this.update_button);
            this.panel_update.Controls.Add(this.update_purchaseDate);
            this.panel_update.Controls.Add(this.update_bookQuantity);
            this.panel_update.Controls.Add(this.update_bookPrice);
            this.panel_update.Controls.Add(this.update_publicationName);
            this.panel_update.Controls.Add(this.update_authorName);
            this.panel_update.Controls.Add(this.update_bookName);
            this.panel_update.Controls.Add(this.label11);
            this.panel_update.Controls.Add(this.label10);
            this.panel_update.Controls.Add(this.label9);
            this.panel_update.Controls.Add(this.label8);
            this.panel_update.Controls.Add(this.label7);
            this.panel_update.Controls.Add(this.label6);
            this.panel_update.Controls.Add(this.Update);
            this.panel_update.Location = new System.Drawing.Point(404, 469);
            this.panel_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(1011, 354);
            this.panel_update.TabIndex = 5;
            this.panel_update.Visible = false;
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(464, 300);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(123, 37);
            this.update_button.TabIndex = 13;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update_purchaseDate
            // 
            this.update_purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.update_purchaseDate.Location = new System.Drawing.Point(669, 60);
            this.update_purchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_purchaseDate.Name = "update_purchaseDate";
            this.update_purchaseDate.Size = new System.Drawing.Size(129, 22);
            this.update_purchaseDate.TabIndex = 12;
            // 
            // update_bookQuantity
            // 
            this.update_bookQuantity.Location = new System.Drawing.Point(619, 245);
            this.update_bookQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_bookQuantity.Name = "update_bookQuantity";
            this.update_bookQuantity.Size = new System.Drawing.Size(321, 22);
            this.update_bookQuantity.TabIndex = 11;
            // 
            // update_bookPrice
            // 
            this.update_bookPrice.Location = new System.Drawing.Point(619, 156);
            this.update_bookPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_bookPrice.Name = "update_bookPrice";
            this.update_bookPrice.Size = new System.Drawing.Size(321, 22);
            this.update_bookPrice.TabIndex = 10;
            // 
            // update_publicationName
            // 
            this.update_publicationName.Location = new System.Drawing.Point(137, 236);
            this.update_publicationName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_publicationName.Name = "update_publicationName";
            this.update_publicationName.Size = new System.Drawing.Size(321, 22);
            this.update_publicationName.TabIndex = 9;
            // 
            // update_authorName
            // 
            this.update_authorName.Location = new System.Drawing.Point(137, 156);
            this.update_authorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_authorName.Name = "update_authorName";
            this.update_authorName.Size = new System.Drawing.Size(321, 22);
            this.update_authorName.TabIndex = 8;
            // 
            // update_bookName
            // 
            this.update_bookName.Location = new System.Drawing.Point(137, 60);
            this.update_bookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_bookName.Name = "update_bookName";
            this.update_bookName.Size = new System.Drawing.Size(321, 22);
            this.update_bookName.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(539, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(539, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Purchase Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Publication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Author Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book Name";
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(435, 0);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(168, 20);
            this.Update.TabIndex = 0;
            this.Update.Text = "UPDATE RECORD";
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 838);
            this.Controls.Add(this.panel_update);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "view_books";
            this.Text = "View Books";
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookName_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookName_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button authorName_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorName_input;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button publicationDate_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker purchaseDate_input;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label Update;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DateTimePicker update_purchaseDate;
        private System.Windows.Forms.TextBox update_bookQuantity;
        private System.Windows.Forms.TextBox update_bookPrice;
        private System.Windows.Forms.TextBox update_publicationName;
        private System.Windows.Forms.TextBox update_authorName;
        private System.Windows.Forms.TextBox update_bookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}