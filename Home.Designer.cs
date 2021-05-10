
namespace Sistema_Oaxaca
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Constanciaspng = new System.Windows.Forms.PictureBox();
            this.LibreriaDocPng = new System.Windows.Forms.PictureBox();
            this.Medicionespng = new System.Windows.Forms.PictureBox();
            this.ModificarDocpng = new System.Windows.Forms.PictureBox();
            this.NuevoDoc = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Constanciaspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibreriaDocPng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medicionespng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModificarDocpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevoDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Constanciaspng
            // 
            this.Constanciaspng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Constanciaspng.Image = global::Sistema_Oaxaca.Properties.Resources.Constancia;
            this.Constanciaspng.Location = new System.Drawing.Point(1154, 530);
            this.Constanciaspng.Name = "Constanciaspng";
            this.Constanciaspng.Size = new System.Drawing.Size(197, 193);
            this.Constanciaspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Constanciaspng.TabIndex = 6;
            this.Constanciaspng.TabStop = false;
            // 
            // LibreriaDocPng
            // 
            this.LibreriaDocPng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibreriaDocPng.Image = global::Sistema_Oaxaca.Properties.Resources.Libreria;
            this.LibreriaDocPng.Location = new System.Drawing.Point(1151, 241);
            this.LibreriaDocPng.Name = "LibreriaDocPng";
            this.LibreriaDocPng.Size = new System.Drawing.Size(200, 200);
            this.LibreriaDocPng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LibreriaDocPng.TabIndex = 3;
            this.LibreriaDocPng.TabStop = false;
            // 
            // Medicionespng
            // 
            this.Medicionespng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medicionespng.Image = global::Sistema_Oaxaca.Properties.Resources.Mediciones;
            this.Medicionespng.Location = new System.Drawing.Point(250, 530);
            this.Medicionespng.Name = "Medicionespng";
            this.Medicionespng.Size = new System.Drawing.Size(197, 193);
            this.Medicionespng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Medicionespng.TabIndex = 2;
            this.Medicionespng.TabStop = false;
            // 
            // ModificarDocpng
            // 
            this.ModificarDocpng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModificarDocpng.Image = global::Sistema_Oaxaca.Properties.Resources.Modificar_Documento;
            this.ModificarDocpng.Location = new System.Drawing.Point(700, 249);
            this.ModificarDocpng.Name = "ModificarDocpng";
            this.ModificarDocpng.Size = new System.Drawing.Size(200, 200);
            this.ModificarDocpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModificarDocpng.TabIndex = 1;
            this.ModificarDocpng.TabStop = false;
            this.ModificarDocpng.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // NuevoDoc
            // 
            this.NuevoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoDoc.Image = ((System.Drawing.Image)(resources.GetObject("NuevoDoc.Image")));
            this.NuevoDoc.Location = new System.Drawing.Point(250, 241);
            this.NuevoDoc.Name = "NuevoDoc";
            this.NuevoDoc.Size = new System.Drawing.Size(200, 200);
            this.NuevoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NuevoDoc.TabIndex = 0;
            this.NuevoDoc.TabStop = false;
            this.NuevoDoc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sistema_Oaxaca.Properties.Resources.Cuadrito;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1614, 174);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.Constanciaspng);
            this.Controls.Add(this.LibreriaDocPng);
            this.Controls.Add(this.Medicionespng);
            this.Controls.Add(this.ModificarDocpng);
            this.Controls.Add(this.NuevoDoc);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Constanciaspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibreriaDocPng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medicionespng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModificarDocpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuevoDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ModificarDocpng;
        private System.Windows.Forms.PictureBox Medicionespng;
        private System.Windows.Forms.PictureBox LibreriaDocPng;
        private System.Windows.Forms.PictureBox NuevoDoc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Constanciaspng;
    }
}

