﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoDoc));
            this.TabNuevoDoc = new System.Windows.Forms.TabControl();
            this.Registro = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Hectareas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NextDocNuevo = new System.Windows.Forms.Button();
            this.Colonias = new System.Windows.Forms.ComboBox();
            this.SolarTerreno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelParajeColonia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreBeneficiario = new System.Windows.Forms.TextBox();
            this.Beneficiario = new System.Windows.Forms.Label();
            this.NombreCedente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EscanearTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FinNuevoDoc = new System.Windows.Forms.Button();
            this.Escanear = new System.Windows.Forms.Button();
            this.ImagenEscaneada = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TabNuevoDoc.SuspendLayout();
            this.Registro.SuspendLayout();
            this.EscanearTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEscaneada)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabNuevoDoc
            // 
            this.TabNuevoDoc.Controls.Add(this.Registro);
            this.TabNuevoDoc.Controls.Add(this.EscanearTab);
            this.TabNuevoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabNuevoDoc.Location = new System.Drawing.Point(87, 120);
            this.TabNuevoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TabNuevoDoc.Name = "TabNuevoDoc";
            this.TabNuevoDoc.SelectedIndex = 0;

            this.TabNuevoDoc.Size = new System.Drawing.Size(779, 451);

            this.TabNuevoDoc.TabIndex = 7;
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.button4);
            this.Registro.Controls.Add(this.button2);
            this.Registro.Controls.Add(this.dateTimePicker1);
            this.Registro.Controls.Add(this.Hectareas);
            this.Registro.Controls.Add(this.label9);
            this.Registro.Controls.Add(this.listBox2);
            this.Registro.Controls.Add(this.listBox1);
            this.Registro.Controls.Add(this.NextDocNuevo);
            this.Registro.Controls.Add(this.Colonias);
            this.Registro.Controls.Add(this.SolarTerreno);
            this.Registro.Controls.Add(this.label4);
            this.Registro.Controls.Add(this.labelParajeColonia);
            this.Registro.Controls.Add(this.label2);
            this.Registro.Controls.Add(this.NombreBeneficiario);
            this.Registro.Controls.Add(this.Beneficiario);
            this.Registro.Controls.Add(this.NombreCedente);
            this.Registro.Controls.Add(this.label1);

            this.Registro.Location = new System.Drawing.Point(4, 29);
            this.Registro.Margin = new System.Windows.Forms.Padding(2);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(2);
            this.Registro.Size = new System.Drawing.Size(771, 418);

            this.Registro.TabIndex = 0;
            this.Registro.Text = "    Registro    ";
            this.Registro.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(692, 50);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(324, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.button2.Name = "button2";

            this.button2.Size = new System.Drawing.Size(20, 23);

            this.button2.TabIndex = 18;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 278);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";

            this.dateTimePicker1.Size = new System.Drawing.Size(187, 26);

            this.dateTimePicker1.TabIndex = 17;
            // 
            // Hectareas
            // 
            this.Hectareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Hectareas.Location = new System.Drawing.Point(562, 212);
            this.Hectareas.Margin = new System.Windows.Forms.Padding(2);
            this.Hectareas.Name = "Hectareas";
            this.Hectareas.Size = new System.Drawing.Size(150, 24);

            this.Hectareas.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label9.Location = new System.Drawing.Point(559, 187);

            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hectareas:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;

            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(422, 80);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(290, 84);

            this.listBox2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;

            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(54, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 84);

            this.listBox1.TabIndex = 12;
            // 
            // NextDocNuevo
            // 
            this.NextDocNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.NextDocNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextDocNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextDocNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDocNuevo.ForeColor = System.Drawing.Color.White;
            this.NextDocNuevo.Location = new System.Drawing.Point(600, 362);
            this.NextDocNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.NextDocNuevo.Name = "NextDocNuevo";

            this.NextDocNuevo.Size = new System.Drawing.Size(111, 30);

            this.NextDocNuevo.TabIndex = 10;
            this.NextDocNuevo.Text = "Siguiente";
            this.NextDocNuevo.UseVisualStyleBackColor = false;
            this.NextDocNuevo.Click += new System.EventHandler(this.NextDocNuevo_Click);
            // 
            // Colonias
            // 
            this.Colonias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colonias.FormattingEnabled = true;

            this.Colonias.Location = new System.Drawing.Point(54, 212);
            this.Colonias.Margin = new System.Windows.Forms.Padding(2);
            this.Colonias.Name = "Colonias";
            this.Colonias.Size = new System.Drawing.Size(290, 25);

            this.Colonias.TabIndex = 9;
            this.Colonias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Colonias_KeyPress);
            // 
            // SolarTerreno
            // 
            this.SolarTerreno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SolarTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolarTerreno.FormattingEnabled = true;

            this.SolarTerreno.Location = new System.Drawing.Point(377, 212);

            this.SolarTerreno.Margin = new System.Windows.Forms.Padding(2);
            this.SolarTerreno.Name = "SolarTerreno";
            this.SolarTerreno.Size = new System.Drawing.Size(159, 25);
            this.SolarTerreno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label4.Location = new System.Drawing.Point(375, 187);

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

            this.labelParajeColonia.Location = new System.Drawing.Point(52, 187);

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

            this.label2.Location = new System.Drawing.Point(51, 256);

            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // NombreBeneficiario
            // 
            this.NombreBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.NombreBeneficiario.Location = new System.Drawing.Point(422, 51);
            this.NombreBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.NombreBeneficiario.Name = "NombreBeneficiario";
            this.NombreBeneficiario.Size = new System.Drawing.Size(268, 24);

            this.NombreBeneficiario.TabIndex = 3;
            this.NombreBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreBeneficiario_KeyPress);
            // 
            // Beneficiario
            // 
            this.Beneficiario.AutoSize = true;
            this.Beneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Beneficiario.Location = new System.Drawing.Point(418, 29);

            this.Beneficiario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Beneficiario.Name = "Beneficiario";
            this.Beneficiario.Size = new System.Drawing.Size(96, 20);
            this.Beneficiario.TabIndex = 2;
            this.Beneficiario.Text = "Beneficiario:";
            // 
            // NombreCedente
            // 
            this.NombreCedente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.NombreCedente.Location = new System.Drawing.Point(54, 50);

            this.NombreCedente.Margin = new System.Windows.Forms.Padding(2);
            this.NombreCedente.Name = "NombreCedente";
            this.NombreCedente.Size = new System.Drawing.Size(268, 24);
            this.NombreCedente.TabIndex = 1;
            this.NombreCedente.Text = "FERNANDO ISAAC NEQUIS ALAN";
            this.NombreCedente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreCedente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label1.Location = new System.Drawing.Point(51, 28);

            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedentes:";
            // 
            // EscanearTab
            // 
            this.EscanearTab.Controls.Add(this.button1);
            this.EscanearTab.Controls.Add(this.label6);
            this.EscanearTab.Controls.Add(this.listView1);
            this.EscanearTab.Controls.Add(this.comboBox1);
            this.EscanearTab.Controls.Add(this.label5);
            this.EscanearTab.Controls.Add(this.label3);
            this.EscanearTab.Controls.Add(this.FinNuevoDoc);
            this.EscanearTab.Controls.Add(this.Escanear);
            this.EscanearTab.Controls.Add(this.ImagenEscaneada);

            this.EscanearTab.Location = new System.Drawing.Point(4, 29);
            this.EscanearTab.Margin = new System.Windows.Forms.Padding(2);
            this.EscanearTab.Name = "EscanearTab";
            this.EscanearTab.Padding = new System.Windows.Forms.Padding(2);
            this.EscanearTab.Size = new System.Drawing.Size(771, 418);

            this.EscanearTab.TabIndex = 1;
            this.EscanearTab.Text = "    Escanear    ";
            this.EscanearTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;

            this.button1.Location = new System.Drawing.Point(628, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);

            this.button1.TabIndex = 7;
            this.button1.Text = "Escanear Pila";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label6.Location = new System.Drawing.Point(229, 92);

            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Documentos Escaneados:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;

            this.listView1.Location = new System.Drawing.Point(232, 115);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(518, 244);

            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;

            this.comboBox1.Location = new System.Drawing.Point(26, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(492, 28);

            this.comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selecciona el Escanner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label3.Location = new System.Drawing.Point(22, 91);

            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vista Previa:";
            // 
            // FinNuevoDoc
            // 
            this.FinNuevoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FinNuevoDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinNuevoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinNuevoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinNuevoDoc.ForeColor = System.Drawing.Color.White;

            this.FinNuevoDoc.Location = new System.Drawing.Point(629, 373);
            this.FinNuevoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.FinNuevoDoc.Name = "FinNuevoDoc";
            this.FinNuevoDoc.Size = new System.Drawing.Size(119, 28);

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

            this.Escanear.Location = new System.Drawing.Point(526, 42);
            this.Escanear.Margin = new System.Windows.Forms.Padding(2);
            this.Escanear.Name = "Escanear";
            this.Escanear.Size = new System.Drawing.Size(89, 28);

            this.Escanear.TabIndex = 2;
            this.Escanear.Text = "Escanear";
            this.Escanear.UseVisualStyleBackColor = false;
            this.Escanear.Click += new System.EventHandler(this.Escanear_Click);
            // 
            // ImagenEscaneada
            // 
            this.ImagenEscaneada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.ImagenEscaneada.Location = new System.Drawing.Point(26, 114);

            this.ImagenEscaneada.Margin = new System.Windows.Forms.Padding(2);
            this.ImagenEscaneada.Name = "ImagenEscaneada";
            this.ImagenEscaneada.Size = new System.Drawing.Size(193, 245);
            this.ImagenEscaneada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenEscaneada.TabIndex = 1;
            this.ImagenEscaneada.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(950, 73);

            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;

            this.label7.Location = new System.Drawing.Point(351, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

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

            this.label8.Location = new System.Drawing.Point(253, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

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

            this.ClientSize = new System.Drawing.Size(950, 645);

            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabNuevoDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "NuevoDoc";
            this.Text = "Nuevo Documento";
            this.Load += new System.EventHandler(this.NuevoDoc_Load_1);
            this.TabNuevoDoc.ResumeLayout(false);
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.EscanearTab.ResumeLayout(false);
            this.EscanearTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenEscaneada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabNuevoDoc;
        private System.Windows.Forms.TabPage Registro;
        private System.Windows.Forms.TabPage EscanearTab;
        private System.Windows.Forms.TextBox NombreCedente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Colonias;
        private System.Windows.Forms.ComboBox SolarTerreno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelParajeColonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreBeneficiario;
        private System.Windows.Forms.Label Beneficiario;
        private System.Windows.Forms.Button NextDocNuevo;
        private System.Windows.Forms.PictureBox ImagenEscaneada;
        private System.Windows.Forms.Button FinNuevoDoc;
        private System.Windows.Forms.Button Escanear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Hectareas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}