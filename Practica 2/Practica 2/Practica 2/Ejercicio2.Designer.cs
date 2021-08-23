
namespace Practica_2
{
    partial class Ejercicio2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoConversion = new System.Windows.Forms.ComboBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lblResultadoTemp = new System.Windows.Forms.Label();
            this.txtDato2Temp = new System.Windows.Forms.TextBox();
            this.txtDato1Temp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbOpc2Temp = new System.Windows.Forms.RadioButton();
            this.rdbOpc1Temp = new System.Windows.Forms.RadioButton();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.lblResultadoLongitud = new System.Windows.Forms.Label();
            this.txtDato1Long = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbOpc2Long = new System.Windows.Forms.RadioButton();
            this.rdbOpc1Long = new System.Windows.Forms.RadioButton();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.lblResultadoPeso = new System.Windows.Forms.Label();
            this.txtDato1Peso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbOpc2Peso = new System.Windows.Forms.RadioButton();
            this.rdbOpc1Peso = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1154, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 101);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Programa de conversiones";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(254)))), ((int)(((byte)(176)))));
            this.groupBox1.Controls.Add(this.cboTipoConversion);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(34, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 112);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de conversión";
            // 
            // cboTipoConversion
            // 
            this.cboTipoConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoConversion.FormattingEnabled = true;
            this.cboTipoConversion.Location = new System.Drawing.Point(7, 37);
            this.cboTipoConversion.Name = "cboTipoConversion";
            this.cboTipoConversion.Size = new System.Drawing.Size(239, 28);
            this.cboTipoConversion.TabIndex = 0;
            this.cboTipoConversion.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversion_SelectedIndexChanged);
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(254)))), ((int)(((byte)(176)))));
            this.group1.Controls.Add(this.lblResultadoTemp);
            this.group1.Controls.Add(this.txtDato2Temp);
            this.group1.Controls.Add(this.txtDato1Temp);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.rdbOpc2Temp);
            this.group1.Controls.Add(this.rdbOpc1Temp);
            this.group1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.group1.Location = new System.Drawing.Point(34, 235);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(341, 347);
            this.group1.TabIndex = 19;
            this.group1.TabStop = false;
            this.group1.Text = "Temperatura";
            // 
            // lblResultadoTemp
            // 
            this.lblResultadoTemp.AutoSize = true;
            this.lblResultadoTemp.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTemp.Location = new System.Drawing.Point(19, 235);
            this.lblResultadoTemp.Name = "lblResultadoTemp";
            this.lblResultadoTemp.Size = new System.Drawing.Size(12, 20);
            this.lblResultadoTemp.TabIndex = 25;
            this.lblResultadoTemp.Text = ".";
            // 
            // txtDato2Temp
            // 
            this.txtDato2Temp.Location = new System.Drawing.Point(91, 174);
            this.txtDato2Temp.Multiline = true;
            this.txtDato2Temp.Name = "txtDato2Temp";
            this.txtDato2Temp.Size = new System.Drawing.Size(190, 27);
            this.txtDato2Temp.TabIndex = 24;
            this.txtDato2Temp.Visible = false;
            this.txtDato2Temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato2Temp_KeyPress);
            // 
            // txtDato1Temp
            // 
            this.txtDato1Temp.Location = new System.Drawing.Point(91, 92);
            this.txtDato1Temp.Multiline = true;
            this.txtDato1Temp.Name = "txtDato1Temp";
            this.txtDato1Temp.Size = new System.Drawing.Size(190, 27);
            this.txtDato1Temp.TabIndex = 23;
            this.txtDato1Temp.TextChanged += new System.EventHandler(this.txtDato1Temp_TextChanged);
            this.txtDato1Temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato1Temp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dato 2\r\n";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dato 1";
            // 
            // rdbOpc2Temp
            // 
            this.rdbOpc2Temp.AutoSize = true;
            this.rdbOpc2Temp.Location = new System.Drawing.Point(170, 49);
            this.rdbOpc2Temp.Name = "rdbOpc2Temp";
            this.rdbOpc2Temp.Size = new System.Drawing.Size(155, 24);
            this.rdbOpc2Temp.TabIndex = 1;
            this.rdbOpc2Temp.TabStop = true;
            this.rdbOpc2Temp.Text = "Fahhrenheit-Celsius";
            this.rdbOpc2Temp.UseVisualStyleBackColor = true;
            // 
            // rdbOpc1Temp
            // 
            this.rdbOpc1Temp.AutoSize = true;
            this.rdbOpc1Temp.Location = new System.Drawing.Point(7, 49);
            this.rdbOpc1Temp.Name = "rdbOpc1Temp";
            this.rdbOpc1Temp.Size = new System.Drawing.Size(147, 24);
            this.rdbOpc1Temp.TabIndex = 0;
            this.rdbOpc1Temp.TabStop = true;
            this.rdbOpc1Temp.Text = "Celsius-Fahrenheit";
            this.rdbOpc1Temp.UseVisualStyleBackColor = true;
            // 
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(254)))), ((int)(((byte)(176)))));
            this.group2.Controls.Add(this.lblResultadoLongitud);
            this.group2.Controls.Add(this.txtDato1Long);
            this.group2.Controls.Add(this.label4);
            this.group2.Controls.Add(this.rdbOpc2Long);
            this.group2.Controls.Add(this.rdbOpc1Long);
            this.group2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.group2.ForeColor = System.Drawing.Color.Black;
            this.group2.Location = new System.Drawing.Point(428, 235);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(341, 347);
            this.group2.TabIndex = 19;
            this.group2.TabStop = false;
            this.group2.Text = "Longitud";
            // 
            // lblResultadoLongitud
            // 
            this.lblResultadoLongitud.AutoSize = true;
            this.lblResultadoLongitud.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoLongitud.Location = new System.Drawing.Point(14, 235);
            this.lblResultadoLongitud.Name = "lblResultadoLongitud";
            this.lblResultadoLongitud.Size = new System.Drawing.Size(12, 20);
            this.lblResultadoLongitud.TabIndex = 26;
            this.lblResultadoLongitud.Text = ".";
            // 
            // txtDato1Long
            // 
            this.txtDato1Long.Location = new System.Drawing.Point(105, 92);
            this.txtDato1Long.Multiline = true;
            this.txtDato1Long.Name = "txtDato1Long";
            this.txtDato1Long.Size = new System.Drawing.Size(190, 27);
            this.txtDato1Long.TabIndex = 25;
            this.txtDato1Long.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato1Long_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dato 1";
            // 
            // rdbOpc2Long
            // 
            this.rdbOpc2Long.AutoSize = true;
            this.rdbOpc2Long.Location = new System.Drawing.Point(190, 49);
            this.rdbOpc2Long.Name = "rdbOpc2Long";
            this.rdbOpc2Long.Size = new System.Drawing.Size(105, 24);
            this.rdbOpc2Long.TabIndex = 3;
            this.rdbOpc2Long.TabStop = true;
            this.rdbOpc2Long.Text = "Pies-Metros\r\n";
            this.rdbOpc2Long.UseVisualStyleBackColor = true;
            // 
            // rdbOpc1Long
            // 
            this.rdbOpc1Long.AutoSize = true;
            this.rdbOpc1Long.Location = new System.Drawing.Point(18, 49);
            this.rdbOpc1Long.Name = "rdbOpc1Long";
            this.rdbOpc1Long.Size = new System.Drawing.Size(105, 24);
            this.rdbOpc1Long.TabIndex = 2;
            this.rdbOpc1Long.TabStop = true;
            this.rdbOpc1Long.Text = "Metros-Pies\r\n";
            this.rdbOpc1Long.UseVisualStyleBackColor = true;
            // 
            // group3
            // 
            this.group3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(254)))), ((int)(((byte)(176)))));
            this.group3.Controls.Add(this.lblResultadoPeso);
            this.group3.Controls.Add(this.txtDato1Peso);
            this.group3.Controls.Add(this.label5);
            this.group3.Controls.Add(this.rdbOpc2Peso);
            this.group3.Controls.Add(this.rdbOpc1Peso);
            this.group3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.group3.ForeColor = System.Drawing.Color.Black;
            this.group3.Location = new System.Drawing.Point(816, 235);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(341, 347);
            this.group3.TabIndex = 20;
            this.group3.TabStop = false;
            this.group3.Text = "Peso";
            // 
            // lblResultadoPeso
            // 
            this.lblResultadoPeso.AutoSize = true;
            this.lblResultadoPeso.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPeso.Location = new System.Drawing.Point(6, 235);
            this.lblResultadoPeso.Name = "lblResultadoPeso";
            this.lblResultadoPeso.Size = new System.Drawing.Size(12, 20);
            this.lblResultadoPeso.TabIndex = 27;
            this.lblResultadoPeso.Text = ".";
            this.lblResultadoPeso.Click += new System.EventHandler(this.lblResultadoPeso_Click);
            // 
            // txtDato1Peso
            // 
            this.txtDato1Peso.Location = new System.Drawing.Point(106, 92);
            this.txtDato1Peso.Multiline = true;
            this.txtDato1Peso.Name = "txtDato1Peso";
            this.txtDato1Peso.Size = new System.Drawing.Size(190, 27);
            this.txtDato1Peso.TabIndex = 25;
            this.txtDato1Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato1Peso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Dato 1";
            // 
            // rdbOpc2Peso
            // 
            this.rdbOpc2Peso.AutoSize = true;
            this.rdbOpc2Peso.Location = new System.Drawing.Point(187, 49);
            this.rdbOpc2Peso.Name = "rdbOpc2Peso";
            this.rdbOpc2Peso.Size = new System.Drawing.Size(148, 24);
            this.rdbOpc2Peso.TabIndex = 2;
            this.rdbOpc2Peso.TabStop = true;
            this.rdbOpc2Peso.Text = "Libras-Kilogramos\r\n";
            this.rdbOpc2Peso.UseVisualStyleBackColor = true;
            // 
            // rdbOpc1Peso
            // 
            this.rdbOpc1Peso.AutoSize = true;
            this.rdbOpc1Peso.Location = new System.Drawing.Point(6, 49);
            this.rdbOpc1Peso.Name = "rdbOpc1Peso";
            this.rdbOpc1Peso.Size = new System.Drawing.Size(148, 24);
            this.rdbOpc1Peso.TabIndex = 1;
            this.rdbOpc1Peso.TabStop = true;
            this.rdbOpc1Peso.Text = "Kilogramos-Libras\r\n";
            this.rdbOpc1Peso.UseVisualStyleBackColor = true;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1192, 609);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.groupBox1.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.ComboBox cboTipoConversion;
        private System.Windows.Forms.RadioButton rdbOpc2Temp;
        private System.Windows.Forms.RadioButton rdbOpc1Temp;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.RadioButton rdbOpc2Long;
        private System.Windows.Forms.RadioButton rdbOpc1Long;
        private System.Windows.Forms.RadioButton rdbOpc2Peso;
        private System.Windows.Forms.RadioButton rdbOpc1Peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDato1Temp;
        private System.Windows.Forms.TextBox txtDato1Long;
        private System.Windows.Forms.TextBox txtDato1Peso;
        private System.Windows.Forms.Label lblResultadoTemp;
        private System.Windows.Forms.Label lblResultadoLongitud;
        private System.Windows.Forms.Label lblResultadoPeso;
        private System.Windows.Forms.TextBox txtDato2Temp;
        private System.Windows.Forms.Label label3;
    }
}