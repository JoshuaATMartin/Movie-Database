namespace DataBase_Media_Project
{
    partial class ViewAll
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
            this.components = new System.ComponentModel.Container();
            this.ViewAllGrid = new System.Windows.Forms.DataGridView();
            this.mediaData = new DataBase_Media_Project.MediaData();
            this.mediaDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAllGrid
            // 
            this.ViewAllGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewAllGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewAllGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAllGrid.Location = new System.Drawing.Point(3, 10);
            this.ViewAllGrid.Name = "ViewAllGrid";
            this.ViewAllGrid.Size = new System.Drawing.Size(1264, 644);
            this.ViewAllGrid.TabIndex = 0;
            // 
            // mediaData
            // 
            this.mediaData.DataSetName = "MediaData";
            this.mediaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediaDataBindingSource
            // 
            this.mediaDataBindingSource.DataSource = this.mediaData;
            this.mediaDataBindingSource.Position = 0;
            // 
            // mediaDataBindingSource1
            // 
            this.mediaDataBindingSource1.DataSource = this.mediaData;
            this.mediaDataBindingSource1.Position = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewAllGrid);
            this.Name = "ViewAll";
            this.Text = "ViewAll";
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewAllGrid;
        private MediaData mediaData;
        private System.Windows.Forms.BindingSource mediaDataBindingSource;
        private System.Windows.Forms.BindingSource mediaDataBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}