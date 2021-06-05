namespace Sistema_Oaxaca
{
    partial class Libreria
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
            this.Cuadrito2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Cuadrito2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuadrito2
            // 
            this.Cuadrito2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.Cuadrito2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cuadrito2.Location = new System.Drawing.Point(0, 0);
            this.Cuadrito2.Margin = new System.Windows.Forms.Padding(2);
            this.Cuadrito2.Name = "Cuadrito2";
            this.Cuadrito2.Size = new System.Drawing.Size(1059, 98);
            this.Cuadrito2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cuadrito2.TabIndex = 8;
            this.Cuadrito2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 462);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Libreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cuadrito2);
            this.Name = "Libreria";
            this.Text = "Libreria";
            ((System.ComponentModel.ISupportInitialize)(this.Cuadrito2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Cuadrito2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}