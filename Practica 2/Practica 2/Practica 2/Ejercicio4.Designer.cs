
namespace Practica_2
{
    partial class Ejercicio4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbCalculo4 = new System.Windows.Forms.TextBox();
            this.txtCalculo3 = new System.Windows.Forms.TextBox();
            this.txbCalculo2 = new System.Windows.Forms.TextBox();
            this.txtbCalculo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.listbArreglo = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(944, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 101);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txbCalculo4);
            this.groupBox1.Controls.Add(this.txtCalculo3);
            this.groupBox1.Controls.Add(this.txbCalculo2);
            this.groupBox1.Controls.Add(this.txtbCalculo1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 324);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLO";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(388, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 32);
            this.button6.TabIndex = 11;
            this.button6.Text = "Mostrar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(388, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "Mostrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(388, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(388, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbCalculo4
            // 
            this.txbCalculo4.Location = new System.Drawing.Point(273, 264);
            this.txbCalculo4.Multiline = true;
            this.txbCalculo4.Name = "txbCalculo4";
            this.txbCalculo4.ReadOnly = true;
            this.txbCalculo4.Size = new System.Drawing.Size(109, 32);
            this.txbCalculo4.TabIndex = 7;
            // 
            // txtCalculo3
            // 
            this.txtCalculo3.Location = new System.Drawing.Point(273, 192);
            this.txtCalculo3.Multiline = true;
            this.txtCalculo3.Name = "txtCalculo3";
            this.txtCalculo3.ReadOnly = true;
            this.txtCalculo3.Size = new System.Drawing.Size(109, 32);
            this.txtCalculo3.TabIndex = 6;
            // 
            // txbCalculo2
            // 
            this.txbCalculo2.Location = new System.Drawing.Point(273, 134);
            this.txbCalculo2.Multiline = true;
            this.txbCalculo2.Name = "txbCalculo2";
            this.txbCalculo2.ReadOnly = true;
            this.txbCalculo2.Size = new System.Drawing.Size(109, 32);
            this.txbCalculo2.TabIndex = 5;
            // 
            // txtbCalculo1
            // 
            this.txtbCalculo1.Location = new System.Drawing.Point(273, 79);
            this.txtbCalculo1.Multiline = true;
            this.txtbCalculo1.Name = "txtbCalculo1";
            this.txtbCalculo1.ReadOnly = true;
            this.txtbCalculo1.Size = new System.Drawing.Size(109, 32);
            this.txtbCalculo1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mayor de los pares positivos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Promedio de impares positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero mayor de pares  negativos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ingrese un valor al arreglo";
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(270, 39);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(95, 20);
            this.txtbNumero.TabIndex = 22;
            this.txtbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumero_KeyPress);
            // 
            // listbArreglo
            // 
            this.listbArreglo.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.listbArreglo.FormattingEnabled = true;
            this.listbArreglo.ItemHeight = 21;
            this.listbArreglo.Location = new System.Drawing.Point(92, 200);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(236, 277);
            this.listbArreglo.TabIndex = 23;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(424, 45);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(183, 40);
            this.btnIngresar.TabIndex = 24;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 531);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio4";
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCalculo4;
        private System.Windows.Forms.TextBox txtCalculo3;
        private System.Windows.Forms.TextBox txbCalculo2;
        private System.Windows.Forms.TextBox txtbCalculo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.ListBox listbArreglo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}