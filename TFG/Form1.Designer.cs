﻿using System.Windows.Forms;

namespace TFG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new LibVLCSharp.WinForms.VideoView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CombTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_CargarCalidades = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ruta = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Descargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CombFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.buttonSeleccionarArchivo = new System.Windows.Forms.Button();
            this.labelSalida = new System.Windows.Forms.Label();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.Btn_RutaSalida = new System.Windows.Forms.Button();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.progressBarConvertir = new System.Windows.Forms.ProgressBar();
            this.comboBoxSalida = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.BackColor = System.Drawing.Color.Black;
            this.Reproductor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reproductor.Location = new System.Drawing.Point(3, 3);
            this.Reproductor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reproductor.MediaPlayer = null;
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.Size = new System.Drawing.Size(844, 430);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.Text = "VLCReproductor";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 462);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CombTipo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btn_CargarCalidades);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Ruta);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btn_Descargar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(850, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descargar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CombTipo
            // 
            this.CombTipo.FormattingEnabled = true;
            this.CombTipo.Items.AddRange(new object[] {
            "Musica",
            "Tutorial",
            "GamePlay",
            "Documental",
            "Animación"});
            this.CombTipo.Location = new System.Drawing.Point(314, 235);
            this.CombTipo.Name = "CombTipo";
            this.CombTipo.Size = new System.Drawing.Size(121, 21);
            this.CombTipo.TabIndex = 26;
            this.CombTipo.Text = "Seleccione Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // btn_CargarCalidades
            // 
            this.btn_CargarCalidades.Location = new System.Drawing.Point(441, 177);
            this.btn_CargarCalidades.Name = "btn_CargarCalidades";
            this.btn_CargarCalidades.Size = new System.Drawing.Size(28, 24);
            this.btn_CargarCalidades.TabIndex = 22;
            this.btn_CargarCalidades.Text = "...";
            this.btn_CargarCalidades.UseVisualStyleBackColor = true;
            this.btn_CargarCalidades.Click += new System.EventHandler(this.btn_CargarCalidades_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Calidad:";
            // 
            // btn_Ruta
            // 
            this.btn_Ruta.Location = new System.Drawing.Point(624, 131);
            this.btn_Ruta.Name = "btn_Ruta";
            this.btn_Ruta.Size = new System.Drawing.Size(25, 23);
            this.btn_Ruta.TabIndex = 20;
            this.btn_Ruta.Text = "...";
            this.btn_Ruta.UseVisualStyleBackColor = true;
            this.btn_Ruta.Click += new System.EventHandler(this.btn_Ruta_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(201, 294);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(477, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // btn_Descargar
            // 
            this.btn_Descargar.BackColor = System.Drawing.Color.Lime;
            this.btn_Descargar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Descargar.Location = new System.Drawing.Point(371, 336);
            this.btn_Descargar.Name = "btn_Descargar";
            this.btn_Descargar.Size = new System.Drawing.Size(154, 58);
            this.btn_Descargar.TabIndex = 18;
            this.btn_Descargar.Text = "Descargar";
            this.btn_Descargar.UseVisualStyleBackColor = false;
            this.btn_Descargar.Click += new System.EventHandler(this.btn_Descargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Carpeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "URL:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CombFiltro);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(850, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descargas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CombFiltro
            // 
            this.CombFiltro.FormattingEnabled = true;
            this.CombFiltro.Items.AddRange(new object[] {
            "Todos",
            "Musica",
            "Tutorial",
            "GamePlay",
            "Documental",
            "Animación"});
            this.CombFiltro.Location = new System.Drawing.Point(663, 23);
            this.CombFiltro.Name = "CombFiltro";
            this.CombFiltro.Size = new System.Drawing.Size(121, 21);
            this.CombFiltro.TabIndex = 1;
            this.CombFiltro.Text = "Seleccione Tipo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(822, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelArchivo);
            this.tabPage3.Controls.Add(this.textBoxArchivo);
            this.tabPage3.Controls.Add(this.buttonSeleccionarArchivo);
            this.tabPage3.Controls.Add(this.labelSalida);
            this.tabPage3.Controls.Add(this.textBoxSalida);
            this.tabPage3.Controls.Add(this.Btn_RutaSalida);
            this.tabPage3.Controls.Add(this.buttonConvertir);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(850, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convertir a MP3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArchivo.Location = new System.Drawing.Point(244, 83);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(82, 21);
            this.labelArchivo.TabIndex = 6;
            this.labelArchivo.Text = "Archivo:";
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(375, 84);
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.Size = new System.Drawing.Size(239, 20);
            this.textBoxArchivo.TabIndex = 5;
            // 
            // buttonSeleccionarArchivo
            // 
            this.buttonSeleccionarArchivo.Location = new System.Drawing.Point(618, 83);
            this.buttonSeleccionarArchivo.Name = "buttonSeleccionarArchivo";
            this.buttonSeleccionarArchivo.Size = new System.Drawing.Size(27, 18);
            this.buttonSeleccionarArchivo.TabIndex = 4;
            this.buttonSeleccionarArchivo.Text = "...";
            this.buttonSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.buttonSeleccionarArchivo.Click += new System.EventHandler(this.buttonSeleccionarArchivo_Click);
            // 
            // labelSalida
            // 
            this.labelSalida.AutoSize = true;
            this.labelSalida.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalida.Location = new System.Drawing.Point(244, 177);
            this.labelSalida.Name = "labelSalida";
            this.labelSalida.Size = new System.Drawing.Size(73, 21);
            this.labelSalida.TabIndex = 3;
            this.labelSalida.Text = "Salida:";
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(375, 177);
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.Size = new System.Drawing.Size(239, 20);
            this.textBoxSalida.TabIndex = 5;
            // 
            // Btn_RutaSalida
            // 
            this.Btn_RutaSalida.Location = new System.Drawing.Point(618, 177);
            this.Btn_RutaSalida.Name = "Btn_RutaSalida";
            this.Btn_RutaSalida.Size = new System.Drawing.Size(27, 21);
            this.Btn_RutaSalida.TabIndex = 4;
            this.Btn_RutaSalida.Text = "...";
            this.Btn_RutaSalida.UseVisualStyleBackColor = true;
            this.Btn_RutaSalida.Click += new System.EventHandler(this.Btn_RutaSalida_Click);
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvertir.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConvertir.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertir.Location = new System.Drawing.Point(352, 264);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(146, 77);
            this.buttonConvertir.TabIndex = 0;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = false;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonPlay);
            this.tabPage4.Controls.Add(this.buttonPause);
            this.tabPage4.Controls.Add(this.buttonStop);
            this.tabPage4.Controls.Add(this.Reproductor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(850, 436);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reproductor Multimedia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // progressBarConvertir
            // 
            this.progressBarConvertir.Location = new System.Drawing.Point(364, 289);
            this.progressBarConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarConvertir.Name = "progressBarConvertir";
            this.progressBarConvertir.Size = new System.Drawing.Size(663, 37);
            this.progressBarConvertir.TabIndex = 1;
            // 
            // comboBoxSalida
            // 
            this.comboBoxSalida.Location = new System.Drawing.Point(0, 0);
            this.comboBoxSalida.Name = "comboBoxSalida";
            this.comboBoxSalida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalida.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TFG.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(716, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 101);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.BackgroundImage = global::TFG.Properties.Resources._3d_play_button_icons_on_transparent_backdrop_free_png;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(333, 274);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(181, 108);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = false;
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Black;
            this.buttonPause.BackgroundImage = global::TFG.Properties.Resources.button_309039_960_720;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(520, 274);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(108, 108);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Black;
            this.buttonStop.BackgroundImage = global::TFG.Properties.Resources._458574;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(216, 274);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(111, 108);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 462);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargar Video de YouTube (TFG)";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox CombFiltro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CombTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_CargarCalidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ruta;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Descargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.Button buttonSeleccionarArchivo;
        private System.Windows.Forms.Label labelSalida;
        private System.Windows.Forms.ComboBox comboBoxSalida;
        private System.Windows.Forms.ProgressBar progressBarConvertir;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxSalida;
        private System.Windows.Forms.Button Btn_RutaSalida;
        private LibVLCSharp.WinForms.VideoView Reproductor;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
    }
}
