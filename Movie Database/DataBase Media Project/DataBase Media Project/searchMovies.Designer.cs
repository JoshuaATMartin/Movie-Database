namespace DataBase_Media_Project
{
    partial class searchMovies
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
            this.button1 = new System.Windows.Forms.Button();
            this.searchMoviesGrid = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingdrop = new System.Windows.Forms.ComboBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchMoviesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchMoviesGrid
            // 
            this.searchMoviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchMoviesGrid.Location = new System.Drawing.Point(0, 240);
            this.searchMoviesGrid.Name = "searchMoviesGrid";
            this.searchMoviesGrid.Size = new System.Drawing.Size(1264, 361);
            this.searchMoviesGrid.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1011, 172);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 25);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // genreBox
            // 
            this.genreBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Items.AddRange(new object[] {
            "Drama",
            "Action",
            "Adventure",
            "Biography",
            "Romance",
            "War",
            "Comedy",
            "Fantasy",
            "Thriller",
            "Crime",
            "Mystery",
            "Sci-Fi",
            "History",
            "Western",
            "Animation"});
            this.genreBox.Location = new System.Drawing.Point(898, 172);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(79, 21);
            this.genreBox.TabIndex = 24;
            this.genreBox.SelectedIndexChanged += new System.EventHandler(this.genreBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(841, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "GENRE:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(635, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Age Restriction:";
            // 
            // ageCombo
            // 
            this.ageCombo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ageCombo.FormattingEnabled = true;
            this.ageCombo.Items.AddRange(new object[] {
            "PG-13",
            "TV-MA",
            "R",
            "G"});
            this.ageCombo.Location = new System.Drawing.Point(726, 174);
            this.ageCombo.Name = "ageCombo";
            this.ageCombo.Size = new System.Drawing.Size(79, 21);
            this.ageCombo.TabIndex = 21;
            this.ageCombo.SelectedIndexChanged += new System.EventHandler(this.ageCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(474, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "RATING:";
            // 
            // ratingdrop
            // 
            this.ratingdrop.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ratingdrop.FormattingEnabled = true;
            this.ratingdrop.Items.AddRange(new object[] {
            "1+",
            "2+",
            "3+",
            "4+",
            "5+",
            "6+",
            "7+",
            "8+",
            "9+"});
            this.ratingdrop.Location = new System.Drawing.Point(549, 174);
            this.ratingdrop.Name = "ratingdrop";
            this.ratingdrop.Size = new System.Drawing.Size(63, 21);
            this.ratingdrop.TabIndex = 19;
            this.ratingdrop.SelectedIndexChanged += new System.EventHandler(this.ratingdrop_SelectedIndexChanged);
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(362, 172);
            this.yearTxt.Multiline = true;
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(85, 25);
            this.yearTxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(284, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "YEAR:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(70, 172);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(163, 25);
            this.nameTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(4, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "NAME:";
            // 
            // searchMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ratingdrop);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchMoviesGrid);
            this.Controls.Add(this.button1);
            this.Name = "searchMovies";
            this.Text = "searchMovies";
            ((System.ComponentModel.ISupportInitialize)(this.searchMoviesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView searchMoviesGrid;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ageCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ratingdrop;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
    }
}