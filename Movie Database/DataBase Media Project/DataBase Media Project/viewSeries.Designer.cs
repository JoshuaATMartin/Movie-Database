namespace DataBase_Media_Project
{
    partial class viewSeries
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
            this.ViewSeriesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSeriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSeriesGrid
            // 
            this.ViewSeriesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewSeriesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewSeriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSeriesGrid.Location = new System.Drawing.Point(1, 2);
            this.ViewSeriesGrid.Name = "ViewSeriesGrid";
            this.ViewSeriesGrid.Size = new System.Drawing.Size(1264, 644);
            this.ViewSeriesGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewSeriesGrid);
            this.Name = "viewSeries";
            this.Text = "viewSeries";
            ((System.ComponentModel.ISupportInitialize)(this.ViewSeriesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewSeriesGrid;
        private System.Windows.Forms.Button button1;
    }
}