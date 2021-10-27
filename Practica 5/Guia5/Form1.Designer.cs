
namespace Guia5
{
    partial class Form1
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
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.BackColor = System.Drawing.Color.Green;
            this.btnEjercicio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnEjercicio1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEjercicio1.Location = new System.Drawing.Point(81, 83);
            this.btnEjercicio1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(139, 47);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio 1";
            this.btnEjercicio1.UseVisualStyleBackColor = false;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.BackColor = System.Drawing.Color.Green;
            this.btnEjercicio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEjercicio2.Location = new System.Drawing.Point(254, 83);
            this.btnEjercicio2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(139, 47);
            this.btnEjercicio2.TabIndex = 1;
            this.btnEjercicio2.Text = "Ejercicio 2";
            this.btnEjercicio2.UseVisualStyleBackColor = false;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(429, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEjercicio1);
            this.Controls.Add(this.btnEjercicio2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEjercicios";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button button1;
    }
}