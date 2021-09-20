namespace Practica_3
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
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpOpc1 = new System.Windows.Forms.GroupBox();
            this.grpOpc2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.lsbMostrar = new System.Windows.Forms.ListBox();
            this.grpOpc3 = new System.Windows.Forms.GroupBox();
            this.lsbReportes = new System.Windows.Forms.ListBox();
            this.nudTamaño = new System.Windows.Forms.NumericUpDown();
            this.grpOpc1.SuspendLayout();
            this.grpOpc2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpOpc3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(1242, -5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 60);
            this.button6.TabIndex = 22;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(364, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingreso alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Número de alumnos:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(387, 35);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(182, 43);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // grpOpc1
            // 
            this.grpOpc1.Controls.Add(this.nudTamaño);
            this.grpOpc1.Controls.Add(this.btnRegistrar);
            this.grpOpc1.Controls.Add(this.label1);
            this.grpOpc1.Location = new System.Drawing.Point(30, 218);
            this.grpOpc1.Name = "grpOpc1";
            this.grpOpc1.Size = new System.Drawing.Size(616, 102);
            this.grpOpc1.TabIndex = 27;
            this.grpOpc1.TabStop = false;
            this.grpOpc1.Text = "Opción de registro";
            // 
            // grpOpc2
            // 
            this.grpOpc2.Controls.Add(this.lsbMostrar);
            this.grpOpc2.Location = new System.Drawing.Point(30, 356);
            this.grpOpc2.Name = "grpOpc2";
            this.grpOpc2.Size = new System.Drawing.Size(699, 304);
            this.grpOpc2.TabIndex = 28;
            this.grpOpc2.TabStop = false;
            this.grpOpc2.Text = "Reportes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboOpcion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(35, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(65, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Escoja una opción:";
            // 
            // cboOpcion
            // 
            this.cboOpcion.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(336, 37);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(228, 29);
            this.cboOpcion.TabIndex = 28;
            this.cboOpcion.SelectedIndexChanged += new System.EventHandler(this.cboOpcion_SelectedIndexChanged);
            // 
            // lsbMostrar
            // 
            this.lsbMostrar.FormattingEnabled = true;
            this.lsbMostrar.Location = new System.Drawing.Point(25, 44);
            this.lsbMostrar.Name = "lsbMostrar";
            this.lsbMostrar.Size = new System.Drawing.Size(656, 251);
            this.lsbMostrar.TabIndex = 0;
            // 
            // grpOpc3
            // 
            this.grpOpc3.Controls.Add(this.lsbReportes);
            this.grpOpc3.Location = new System.Drawing.Point(762, 356);
            this.grpOpc3.Name = "grpOpc3";
            this.grpOpc3.Size = new System.Drawing.Size(502, 304);
            this.grpOpc3.TabIndex = 29;
            this.grpOpc3.TabStop = false;
            this.grpOpc3.Text = "Listado de estudiantes";
            // 
            // lsbReportes
            // 
            this.lsbReportes.FormattingEnabled = true;
            this.lsbReportes.Location = new System.Drawing.Point(37, 44);
            this.lsbReportes.Name = "lsbReportes";
            this.lsbReportes.Size = new System.Drawing.Size(453, 251);
            this.lsbReportes.TabIndex = 0;
            // 
            // nudTamaño
            // 
            this.nudTamaño.Location = new System.Drawing.Point(232, 46);
            this.nudTamaño.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamaño.Name = "nudTamaño";
            this.nudTamaño.Size = new System.Drawing.Size(120, 20);
            this.nudTamaño.TabIndex = 27;
            this.nudTamaño.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudTamaño_KeyPress);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1276, 690);
            this.Controls.Add(this.grpOpc3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpOpc2);
            this.Controls.Add(this.grpOpc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.grpOpc1.ResumeLayout(false);
            this.grpOpc1.PerformLayout();
            this.grpOpc2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpOpc3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox grpOpc1;
        private System.Windows.Forms.GroupBox grpOpc2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbMostrar;
        private System.Windows.Forms.GroupBox grpOpc3;
        private System.Windows.Forms.ListBox lsbReportes;
        private System.Windows.Forms.NumericUpDown nudTamaño;
    }
}