namespace ProyectoOrganizacionFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoDec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.convertToBin = new System.Windows.Forms.Label();
            this.convertToC2 = new System.Windows.Forms.Label();
            this.sumaResultado = new System.Windows.Forms.Label();
            this.C2ToDecimal = new System.Windows.Forms.Label();
            this.BoothTable = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmo de Booth";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(92, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduce los numeros decimales que vas a utilizar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(381, 106);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(381, 144);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(262, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decimal 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(262, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Decimal 2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultadoDec
            // 
            this.resultadoDec.AutoSize = true;
            this.resultadoDec.Font = new System.Drawing.Font("Consolas", 14F);
            this.resultadoDec.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.resultadoDec.Location = new System.Drawing.Point(351, 216);
            this.resultadoDec.Name = "resultadoDec";
            this.resultadoDec.Size = new System.Drawing.Size(0, 22);
            this.resultadoDec.TabIndex = 6;
            this.resultadoDec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // convertToBin
            // 
            this.convertToBin.AutoSize = true;
            this.convertToBin.Font = new System.Drawing.Font("Consolas", 12F);
            this.convertToBin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.convertToBin.Location = new System.Drawing.Point(93, 243);
            this.convertToBin.Name = "convertToBin";
            this.convertToBin.Size = new System.Drawing.Size(45, 19);
            this.convertToBin.TabIndex = 8;
            this.convertToBin.Text = "null";
            this.convertToBin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convertToC2
            // 
            this.convertToC2.AutoSize = true;
            this.convertToC2.Font = new System.Drawing.Font("Consolas", 12F);
            this.convertToC2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.convertToC2.Location = new System.Drawing.Point(93, 274);
            this.convertToC2.Name = "convertToC2";
            this.convertToC2.Size = new System.Drawing.Size(45, 19);
            this.convertToC2.TabIndex = 9;
            this.convertToC2.Text = "null";
            this.convertToC2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sumaResultado
            // 
            this.sumaResultado.AutoSize = true;
            this.sumaResultado.Font = new System.Drawing.Font("Consolas", 12F);
            this.sumaResultado.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.sumaResultado.Location = new System.Drawing.Point(93, 206);
            this.sumaResultado.Name = "sumaResultado";
            this.sumaResultado.Size = new System.Drawing.Size(45, 19);
            this.sumaResultado.TabIndex = 10;
            this.sumaResultado.Text = "null";
            this.sumaResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // C2ToDecimal
            // 
            this.C2ToDecimal.AutoSize = true;
            this.C2ToDecimal.Font = new System.Drawing.Font("Consolas", 12F);
            this.C2ToDecimal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.C2ToDecimal.Location = new System.Drawing.Point(93, 620);
            this.C2ToDecimal.Name = "C2ToDecimal";
            this.C2ToDecimal.Size = new System.Drawing.Size(45, 19);
            this.C2ToDecimal.TabIndex = 12;
            this.C2ToDecimal.Text = "null";
            this.C2ToDecimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoothTable
            // 
            this.BoothTable.Font = new System.Drawing.Font("Consolas", 12F);
            this.BoothTable.FormattingEnabled = true;
            this.BoothTable.ItemHeight = 19;
            this.BoothTable.Location = new System.Drawing.Point(186, 321);
            this.BoothTable.Name = "BoothTable";
            this.BoothTable.Size = new System.Drawing.Size(491, 270);
            this.BoothTable.TabIndex = 13;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resetButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(710, 321);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 23);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(873, 498);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.BoothTable);
            this.Controls.Add(this.C2ToDecimal);
            this.Controls.Add(this.sumaResultado);
            this.Controls.Add(this.convertToC2);
            this.Controls.Add(this.convertToBin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultadoDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultadoDec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label convertToBin;
        private System.Windows.Forms.Label convertToC2;
        private System.Windows.Forms.Label sumaResultado;
        private System.Windows.Forms.Label C2ToDecimal;
        public System.Windows.Forms.ListBox BoothTable;
        private System.Windows.Forms.Button resetButton;
    }
}

