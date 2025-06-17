namespace Algoritmos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCircleBre = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRadius = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLineBre = new System.Windows.Forms.Button();
            this.BtnLineDDA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtY1 = new System.Windows.Forms.TextBox();
            this.TxtX1 = new System.Windows.Forms.TextBox();
            this.TxtY0 = new System.Windows.Forms.TextBox();
            this.TxtX0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCircleBre);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.TxtRadius);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(4, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 158);
            this.panel4.TabIndex = 1;
            // 
            // BtnCircleBre
            // 
            this.BtnCircleBre.Location = new System.Drawing.Point(6, 96);
            this.BtnCircleBre.Name = "BtnCircleBre";
            this.BtnCircleBre.Size = new System.Drawing.Size(95, 23);
            this.BtnCircleBre.TabIndex = 12;
            this.BtnCircleBre.Text = "Bresenham";
            this.BtnCircleBre.UseVisualStyleBackColor = true;
            this.BtnCircleBre.Click += new System.EventHandler(this.BtnCircleBres_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Círculo";
            // 
            // TxtRadius
            // 
            this.TxtRadius.Location = new System.Drawing.Point(53, 40);
            this.TxtRadius.Name = "TxtRadius";
            this.TxtRadius.Size = new System.Drawing.Size(163, 22);
            this.TxtRadius.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Radio";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnLineBre);
            this.panel3.Controls.Add(this.BtnLineDDA);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtY1);
            this.panel3.Controls.Add(this.TxtX1);
            this.panel3.Controls.Add(this.TxtY0);
            this.panel3.Controls.Add(this.TxtX0);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 180);
            this.panel3.TabIndex = 0;
            // 
            // BtnLineBre
            // 
            this.BtnLineBre.Location = new System.Drawing.Point(122, 149);
            this.BtnLineBre.Name = "BtnLineBre";
            this.BtnLineBre.Size = new System.Drawing.Size(95, 23);
            this.BtnLineBre.TabIndex = 11;
            this.BtnLineBre.Text = "Bresenham";
            this.BtnLineBre.UseVisualStyleBackColor = true;
            this.BtnLineBre.Click += new System.EventHandler(this.BtnLineBre_Click);
            // 
            // BtnLineDDA
            // 
            this.BtnLineDDA.Location = new System.Drawing.Point(7, 149);
            this.BtnLineDDA.Name = "BtnLineDDA";
            this.BtnLineDDA.Size = new System.Drawing.Size(94, 23);
            this.BtnLineDDA.TabIndex = 10;
            this.BtnLineDDA.Text = "DDA";
            this.BtnLineDDA.UseVisualStyleBackColor = true;
            this.BtnLineDDA.Click += new System.EventHandler(this.BtnLineDDA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Linea";
            // 
            // TxtY1
            // 
            this.TxtY1.Location = new System.Drawing.Point(31, 121);
            this.TxtY1.Name = "TxtY1";
            this.TxtY1.Size = new System.Drawing.Size(186, 22);
            this.TxtY1.TabIndex = 7;
            // 
            // TxtX1
            // 
            this.TxtX1.Location = new System.Drawing.Point(31, 93);
            this.TxtX1.Name = "TxtX1";
            this.TxtX1.Size = new System.Drawing.Size(186, 22);
            this.TxtX1.TabIndex = 6;
            // 
            // TxtY0
            // 
            this.TxtY0.Location = new System.Drawing.Point(31, 65);
            this.TxtY0.Name = "TxtY0";
            this.TxtY0.Size = new System.Drawing.Size(186, 22);
            this.TxtY0.TabIndex = 5;
            // 
            // TxtX0
            // 
            this.TxtX0.Location = new System.Drawing.Point(31, 33);
            this.TxtX0.Name = "TxtX0";
            this.TxtX0.Size = new System.Drawing.Size(186, 22);
            this.TxtX0.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picCanvas);
            this.panel2.Location = new System.Drawing.Point(245, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 505);
            this.panel2.TabIndex = 1;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(3, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(605, 499);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtY1;
        private System.Windows.Forms.TextBox TxtX1;
        private System.Windows.Forms.TextBox TxtY0;
        private System.Windows.Forms.TextBox TxtX0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRadius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCircleBre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLineBre;
        private System.Windows.Forms.Button BtnLineDDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

