
namespace Sistema_Oaxaca
{
    partial class NuevoDoc
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
            this.TabNuevoDoc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.NextDocNuevo = new System.Windows.Forms.Button();
            this.Colonias = new System.Windows.Forms.ComboBox();
            this.SolarTerreno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelParajeColonia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Beneficiario = new System.Windows.Forms.Label();
            this.NombreCedente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FinNuevoDoc = new System.Windows.Forms.Button();
            this.Escanear = new System.Windows.Forms.Button();
            this.ImagenEscaneada = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabNuevoDoc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEscaneada)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabNuevoDoc
            // 
            this.TabNuevoDoc.Controls.Add(this.tabPage1);
            this.TabNuevoDoc.Controls.Add(this.tabPage2);
            this.TabNuevoDoc.Location = new System.Drawing.Point(22, 91);
            this.TabNuevoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TabNuevoDoc.Name = "TabNuevoDoc";
            this.TabNuevoDoc.SelectedIndex = 0;
            this.TabNuevoDoc.Size = new System.Drawing.Size(1009, 488);
            this.TabNuevoDoc.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.NextDocNuevo);
            this.tabPage1.Controls.Add(this.Colonias);
            this.tabPage1.Controls.Add(this.SolarTerreno);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelParajeColonia);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Beneficiario);
            this.tabPage1.Controls.Add(this.NombreCedente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1001, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(162, 238);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // NextDocNuevo
            // 
            this.NextDocNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NextDocNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextDocNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDocNuevo.Location = new System.Drawing.Point(691, 262);
            this.NextDocNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.NextDocNuevo.Name = "NextDocNuevo";
            this.NextDocNuevo.Size = new System.Drawing.Size(106, 56);
            this.NextDocNuevo.TabIndex = 10;
            this.NextDocNuevo.Text = "Siguiente";
            this.NextDocNuevo.UseVisualStyleBackColor = false;
            this.NextDocNuevo.Click += new System.EventHandler(this.NextDocNuevo_Click);
            // 
            // Colonias
            // 
            this.Colonias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colonias.FormattingEnabled = true;
            this.Colonias.Location = new System.Drawing.Point(614, 149);
            this.Colonias.Margin = new System.Windows.Forms.Padding(2);
            this.Colonias.Name = "Colonias";
            this.Colonias.Size = new System.Drawing.Size(184, 25);
            this.Colonias.TabIndex = 9;
            // 
            // SolarTerreno
            // 
            this.SolarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarTerreno.FormattingEnabled = true;
            this.SolarTerreno.Location = new System.Drawing.Point(614, 81);
            this.SolarTerreno.Margin = new System.Windows.Forms.Padding(2);
            this.SolarTerreno.Name = "SolarTerreno";
            this.SolarTerreno.Size = new System.Drawing.Size(184, 25);
            this.SolarTerreno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Solar o Terreno:";
            // 
            // labelParajeColonia
            // 
            this.labelParajeColonia.AutoSize = true;
            this.labelParajeColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParajeColonia.Location = new System.Drawing.Point(481, 150);
            this.labelParajeColonia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParajeColonia.Name = "labelParajeColonia";
            this.labelParajeColonia.Size = new System.Drawing.Size(58, 20);
            this.labelParajeColonia.TabIndex = 6;
            this.labelParajeColonia.Text = "Paraje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 24);
            this.textBox1.TabIndex = 3;
            // 
            // Beneficiario
            // 
            this.Beneficiario.AutoSize = true;
            this.Beneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beneficiario.Location = new System.Drawing.Point(68, 150);
            this.Beneficiario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Beneficiario.Name = "Beneficiario";
            this.Beneficiario.Size = new System.Drawing.Size(96, 20);
            this.Beneficiario.TabIndex = 2;
            this.Beneficiario.Text = "Beneficiario:";
            // 
            // NombreCedente
            // 
            this.NombreCedente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCedente.Location = new System.Drawing.Point(162, 80);
            this.NombreCedente.Margin = new System.Windows.Forms.Padding(2);
            this.NombreCedente.Name = "NombreCedente";
            this.NombreCedente.Size = new System.Drawing.Size(198, 24);
            this.NombreCedente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.FinNuevoDoc);
            this.tabPage2.Controls.Add(this.Escanear);
            this.tabPage2.Controls.Add(this.ImagenEscaneada);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1001, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Escanear";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selecciona el Escanner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento Escaneado:";
            // 
            // FinNuevoDoc
            // 
            this.FinNuevoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FinNuevoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinNuevoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinNuevoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinNuevoDoc.ForeColor = System.Drawing.Color.White;
            this.FinNuevoDoc.Location = new System.Drawing.Point(866, 407);
            this.FinNuevoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.FinNuevoDoc.Name = "FinNuevoDoc";
            this.FinNuevoDoc.Size = new System.Drawing.Size(107, 32);
            this.FinNuevoDoc.TabIndex = 3;
            this.FinNuevoDoc.Text = "Terminar";
            this.FinNuevoDoc.UseVisualStyleBackColor = false;
            this.FinNuevoDoc.Click += new System.EventHandler(this.FinNuevoDoc_Click);
            // 
            // Escanear
            // 
            this.Escanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Escanear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Escanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escanear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escanear.ForeColor = System.Drawing.Color.White;
            this.Escanear.Location = new System.Drawing.Point(18, 407);
            this.Escanear.Margin = new System.Windows.Forms.Padding(2);
            this.Escanear.Name = "Escanear";
            this.Escanear.Size = new System.Drawing.Size(237, 32);
            this.Escanear.TabIndex = 2;
            this.Escanear.Text = "Escanear";
            this.Escanear.UseVisualStyleBackColor = false;
            this.Escanear.Click += new System.EventHandler(this.Escanear_Click);
            // 
            // ImagenEscaneada
            // 
            this.ImagenEscaneada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenEscaneada.Location = new System.Drawing.Point(18, 102);
            this.ImagenEscaneada.Margin = new System.Windows.Forms.Padding(2);
            this.ImagenEscaneada.Name = "ImagenEscaneada";
            this.ImagenEscaneada.Size = new System.Drawing.Size(237, 301);
            this.ImagenEscaneada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenEscaneada.TabIndex = 1;
            this.ImagenEscaneada.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(279, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 300);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Documentos Escaneados:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 74);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(415, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nuevo Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(281, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(465, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Comisariado Huaxpaltepec, Oax";
            // 
            // NuevoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1051, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabNuevoDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NuevoDoc";
            this.Text = "Nuevo Documento";
            this.Load += new System.EventHandler(this.NuevoDoc_Load_1);
            this.TabNuevoDoc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEscaneada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabNuevoDoc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NombreCedente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Colonias;
        private System.Windows.Forms.ComboBox SolarTerreno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelParajeColonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Beneficiario;
        private System.Windows.Forms.Button NextDocNuevo;
        private System.Windows.Forms.PictureBox ImagenEscaneada;
        private System.Windows.Forms.Button FinNuevoDoc;
        private System.Windows.Forms.Button Escanear;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}