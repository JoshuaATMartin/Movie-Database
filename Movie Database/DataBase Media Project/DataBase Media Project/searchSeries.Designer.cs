namespace DataBase_Media_Project
{
    partial class searchSeries
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
            this.searchSeriesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.ratingdrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchSeriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchSeriesGrid
            // 
            this.searchSeriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchSeriesGrid.Location = new System.Drawing.Point(-1, 240);
            this.searchSeriesGrid.Name = "searchSeriesGrid";
            this.searchSeriesGrid.Size = new System.Drawing.Size(1264, 361);
            this.searchSeriesGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(78, 167);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(163, 25);
            this.nameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(292, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "YEAR:";
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(370, 167);
            this.yearTxt.Multiline = true;
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(85, 25);
            this.yearTxt.TabIndex = 4;
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
            this.ratingdrop.Location = new System.Drawing.Point(557, 169);
            this.ratingdrop.Name = "ratingdrop";
            this.ratingdrop.Size = new System.Drawing.Size(63, 21);
            this.ratingdrop.TabIndex = 5;
            this.ratingdrop.SelectedIndexChanged += new System.EventHandler(this.ratingdrop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(482, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "RATING:";
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
            this.ageCombo.Location = new System.Drawing.Point(734, 169);
            this.ageCombo.Name = "ageCombo";
            this.ageCombo.Size = new System.Drawing.Size(79, 21);
            this.ageCombo.TabIndex = 7;
            this.ageCombo.SelectedIndexChanged += new System.EventHandler(this.ageCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(643, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age Restriction:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(849, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "GENRE:";
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
            this.genreBox.Location = new System.Drawing.Point(906, 167);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(79, 21);
            this.genreBox.TabIndex = 10;
            this.genreBox.SelectedIndexChanged += new System.EventHandler(this.genreBox_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1019, 167);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 25);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.searchSeriesGrid);
            this.Name = "searchSeries";
            this.Text = "searchSeries";
            ((System.ComponentModel.ISupportInitialize)(this.searchSeriesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchSeriesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.ComboBox ratingdrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ageCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
    }
}