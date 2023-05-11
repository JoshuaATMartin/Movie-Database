namespace DataBase_Media_Project
{
    partial class viewMovies
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
            this.ViewMoviesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMoviesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewMoviesGrid
            // 
            this.ViewMoviesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewMoviesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewMoviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMoviesGrid.Location = new System.Drawing.Point(3, 3);
            this.ViewMoviesGrid.Name = "ViewMoviesGrid";
            this.ViewMoviesGrid.Size = new System.Drawing.Size(1264, 644);
            this.ViewMoviesGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewMoviesGrid);
            this.Name = "viewMovies";
            this.Text = "viewMovies";
            ((System.ComponentModel.ISupportInitialize)(this.ViewMoviesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewMoviesGrid;
        private System.Windows.Forms.Button button1;
    }
}