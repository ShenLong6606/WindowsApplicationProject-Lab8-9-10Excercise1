namespace Windows_Application_Project
{
    partial class Filter1
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
            this.SelectStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Data = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectStatus
            // 
            this.SelectStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SelectStatus.FormattingEnabled = true;
            this.SelectStatus.ItemHeight = 19;
            this.SelectStatus.Items.AddRange(new object[] {
            "Best sold",
            "Least sold",
            "Good quality",
            "Sell off",
            "Premium"});
            this.SelectStatus.Location = new System.Drawing.Point(118, 68);
            this.SelectStatus.Name = "SelectStatus";
            this.SelectStatus.Size = new System.Drawing.Size(306, 27);
            this.SelectStatus.TabIndex = 0;
            this.SelectStatus.SelectedIndexChanged += new System.EventHandler(this.SelectStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter";
            // 
            // tb_Data
            // 
            this.tb_Data.AllowUserToAddRows = false;
            this.tb_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_Data.Location = new System.Drawing.Point(46, 188);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(715, 250);
            this.tb_Data.TabIndex = 14;
            this.tb_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_Data_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Windows_Application_Project.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Filter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectStatus);
            this.Name = "Filter1";
            this.Text = "Filter1";
            this.Load += new System.EventHandler(this.Filter1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tb_Data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}