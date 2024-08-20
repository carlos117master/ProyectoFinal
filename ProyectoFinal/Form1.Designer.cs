namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Jugar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cuadroTexto = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Jugar
            // 
            Jugar.BackColor = System.Drawing.Color.Lime;
            Jugar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Jugar.Location = new System.Drawing.Point(60, 88);
            Jugar.Name = "Jugar";
            Jugar.Size = new System.Drawing.Size(94, 63);
            Jugar.TabIndex = 0;
            Jugar.Text = "Jugar";
            Jugar.UseVisualStyleBackColor = false;
            Jugar.Click += Jugar_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(253, 88);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 63);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            richTextBox1.ForeColor = System.Drawing.Color.Red;
            richTextBox1.Location = new System.Drawing.Point(60, 288);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(273, 262);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(97, 233);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(198, 29);
            label1.TabIndex = 4;
            label1.Text = "Instrucciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Red;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(83, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(231, 43);
            label2.TabIndex = 5;
            label2.Text = "Coche Loco";
            // 
            // cuadroTexto
            // 
            cuadroTexto.Location = new System.Drawing.Point(97, 203);
            cuadroTexto.Name = "cuadroTexto";
            cuadroTexto.Size = new System.Drawing.Size(198, 27);
            cuadroTexto.TabIndex = 6;
            cuadroTexto.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Gold;
            label3.Location = new System.Drawing.Point(168, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 18);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagenMenu;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(382, 562);
            Controls.Add(label3);
            Controls.Add(cuadroTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(Jugar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuadroTexto;
        private System.Windows.Forms.Label label3;
    }
}
